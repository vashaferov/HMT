using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace HMT

{
    public partial class Form1 : Form
    {
        string subResultText = "";
        string resultText = "";
        string line;
        string[] subLine;
        string processName = Settings.Default.process;
        string steepNum;
        string testNum;
        string screanPath = Settings.Default.screenshot;

        public Form1()
        {
            InitializeComponent();
        }

        //��� ���������
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
        //�������� ���������
        private void screanshotButton_Click(object sender, EventArgs e)
        {
            resultText = "";
            steepNum = steepTextBox.Text;
            testNum = testTextBox.Text;
            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screanPath + testNum);
                screanPath += testNum + "\\" + "��� " + steepNum + ".png";

                if (Settings.Default.typeScreen == 1)
                    screenProcessWindow(screanPath, processName);
                else if (Settings.Default.typeScreen == 2)
                    screenFullWindow(screanPath, processName);


                steepTextBox.Text = null;
                screanPath = Settings.Default.screenshot;
            } else
            {
                resultTextBox.Text = "�� ������ ������ ���� ��� ����� �����";
            }
            
        }
        //
        //��������� �������� RB � "�����"
        private void eventGB_mouseClick(object sender, EventArgs e)
        {
            resultText = "";
            subResultText = "";
            resultTextBox.Text = "";
            logRB.Checked = false;
            linkRB.Checked = false;

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
        //��������� �������� RB � "������"
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
        //������ ����� � ��������, ��������� ������ �� ������, �������� "�����������"
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
                resultTextBox.Text = "������ ��� ������ �����";
            }

        }
        //
        private void Btn_Click(object? sender, EventArgs e)
        {
            Clipboard.SetText(subLine[1]);
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void screenProcessWindow(String screanPath, String processName)
        {
            try
            {
                var process = Process.GetProcessesByName(processName).FirstOrDefault();
                var hwnd = process.MainWindowHandle;
                GetWindowRect(hwnd, out var rect);

                using (var image = new Bitmap(rect.Right - rect.Left, rect.Bottom - rect.Top))
                {
                    using (var graphics = Graphics.FromImage(image))
                    {
                        var hdcBitmap = graphics.GetHdc();
                        PrintWindow(hwnd, hdcBitmap, 0);
                        graphics.ReleaseHdc(hdcBitmap);
                    }
                    image.Save(screanPath, ImageFormat.Png);
                }
                resultTextBox.Text = "�������� ����� � " + testNum + " '��� " + steepNum + "' �����";
            } catch (Exception e)
            {
                resultTextBox.Text = "�� ������ �������";
            }
        }

        private void screenFullWindow(String screanPath, String processName)
        {
            int width = Settings.Default.monitorSize.Width;
            int height = Settings.Default.monitorSize.Height;
            Point point = Settings.Default.monitorLocetion;
            Bitmap printscreen = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(point, new Point(0, 0), printscreen.Size);
            printscreen.Save(screanPath, ImageFormat.Png);
            resultTextBox.Text = "�������� ����� � " + testNum + " '��� " + steepNum + "' �����";
        }
    }
}