using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace HMT

{
    public partial class Form1 : Form
    {
        string subResultText = "";
        string resultText = "";
        string line;
        string[] subLine;
        string processName;
        string steepNum;
        string testNum;
        string screanPath;
        string release;

        public Form1()
        {
            InitializeComponent();
             if (Settings.Default.firstStart == true)
            {
                MessageBox.Show("...", "Информация", MessageBoxButtons.OK);
                Settings.Default.firstStart = false;
                Settings.Default.Save();
            }
        }

        //Для скриншота
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;
        }
        //
        //Создание скриншота
        private void screanshotButton_Click(object sender, EventArgs e)
        {
            resultText = "";
            screanPath = Settings.Default.screenshot;
            processName = Settings.Default.process;
            release = Settings.Default.release;
            steepNum = steepTextBox.Text.Trim();
            testNum = testTextBox.Text.Trim();
            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screanPath + "\\" + release + "\\" + testNum);
                screanPath += "\\" + release + "\\" + testNum + "\\" + "Шаг " + steepNum + ".png";

                this.WindowState = FormWindowState.Minimized;

                if (Settings.Default.typeScreen == 1)
                    screenProcessWindow(screanPath, processName);
                else if (Settings.Default.typeScreen == 2)
                    screenFullWindow(screanPath);

                this.WindowState = FormWindowState.Normal;
                steepTextBox.Text = null;
                screanPath = Settings.Default.screenshot;
            } else
            {
                resultTextBox.Text = "Не указан нормер шага или номер теста";
            }
            
        }
        //
        //Получение нажатого RB в "стенд"
        private void eventGB_mouseClick(object sender, EventArgs e)
        {
            resultText = "";
            subResultText = "";
            resultTextBox.Text = "";
            logRB.Checked = false;
            linkRB.Checked = false;
            resultButtonPane.Controls.Clear();

            foreach (RadioButton rb in envGB.Controls.OfType<RadioButton>())
            {
                if (rb.Checked == true)
                {
                    subResultText = rb.Text;
                    sectionGB.Visible = true;
                }

            }

        }
        //
        //Получение нажатого RB в "раздел"
        private void sectionGB_mouseClick(object sender, EventArgs e)
        {
            foreach (RadioButton rb in sectionGB.Controls.OfType<RadioButton>())
            {
                if(rb.Checked == true)
                {
                    resultText = subResultText + "_" + rb.Text;
                    showResult(resultText);
                }
            }

        }
        //
        //Чтение файла с ссылками, отрисовка кнопок на экране, привязка "копирования"
        private void showResult(string resultText)
        {
            resultButtonPane.Controls.Clear();
            try
            {
                StreamReader sr = new StreamReader(Settings.Default.conf);
                line = sr.ReadLine();
                while(line != null)
                {
                    if(line == "--"+resultText)
                    {
                        line = sr.ReadLine().Trim();
                        while (line != "---")
                        {
                            subLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            Button btn = new Button();
                            btn.Text = subLine[0];
                            btn.Click += Btn_Click;
                            resultButtonPane.Controls.Add(btn);
                            line = sr.ReadLine().Trim();
                        }
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            } catch (Exception e) {
                resultTextBox.Text = "Ошибка при чтении файла";
            }

        }
        //
        // Запись действия на кнопку
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            StreamReader sr1 = new StreamReader(Settings.Default.conf);
            line = sr1.ReadLine();
            while (line != null)
            {
                subLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (subLine[0] == btn.Text)
                {
                    Clipboard.SetText(subLine[1]);
                    break;
                }
                line = sr1.ReadLine();
            }
            sr1.Close();
        }
        //
        // Открытие окна "Настройки"
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }
        //
        // Скриншот процесса
        private void screenProcessWindow(String screanPath, String processName)
        {
            try
            {
                var process = Process.GetProcessesByName(processName).FirstOrDefault();
                var hwnd = process.MainWindowHandle;
                GetWindowRect(hwnd, out var rect);

                using (var printscreen = new Bitmap(rect.Right - rect.Left, rect.Bottom - rect.Top))
                {
                    using (var graphics = Graphics.FromImage(printscreen))
                    {
                        var hdcBitmap = graphics.GetHdc();
                        PrintWindow(hwnd, hdcBitmap, 0);
                        graphics.ReleaseHdc(hdcBitmap);
                        if (Settings.Default.numOnScreen == true)
                            numOnScreen(graphics);
                    }

                    printscreen.Save(screanPath, ImageFormat.Png);
                }
                resultTextBox.Text = "Скриншот теста № " + testNum + " 'Шаг " + steepNum + "' готов";
            } catch (Exception e)
            {
                resultTextBox.Text = "Не указан процесс";
            }
        }
        //
        // Скриншот монитора
        private void screenFullWindow(String screanPath)
        {
            int width = Settings.Default.monitorSize.Width;
            int height = Settings.Default.monitorSize.Height;
            Point point = Settings.Default.monitorLocetion;
            Bitmap printscreen = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(point, new Point(0, 0), printscreen.Size);
            if(Settings.Default.numOnScreen == true)
                numOnScreen(graphics);
            printscreen.Save(screanPath, ImageFormat.Png);
            resultTextBox.Text = "Скриншот теста № " + testNum + " 'Шаг " + steepNum + "' готов";
            graphics = null;
            printscreen = null;
        }
        //
        // Номер теста и шага на скриншоте
        private void numOnScreen(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color.Black, 100), 0, 0, 172, 17);
            graphics.DrawRectangle(new Pen(Color.White, 100), 0, 0, 170, 15);
            graphics.DrawString("Тест № " + testNum + "\nШаг № " + steepNum, new Font("Verdana", (float)20), new SolidBrush(Color.Red), 0, 0);
        }
        //
    }
}