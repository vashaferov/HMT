
using System.Diagnostics;

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
        string userName = Environment.UserName;
        //string pathToConfig = "C:\\Users\\Вячеслав\\Documents\\" + Environment.UserName + ".txt";
        string pathToConfig = "\\\\Client\\M$\\" + Environment.UserName + ".txt";

        public Form1()
        {
            InitializeComponent();
            // Проверка на первый запуск

                //if (Settings.Default.firstStart == true)
                //{
                //    Settings.Default.conf = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HMT\\conf.txt";
                //    Settings.Default.firstStart = false;
                //    Settings.Default.Save();
                //}
            UserConfigHelper.CheckConfig(userName);
            //
        }
        //Создание скриншота
        private void screanshotButton_Click(object sender, EventArgs e)
        {
            resultText = "";
            //screanPath = Settings.Default.screenshot;
            //processName = Settings.Default.process;
            //release = Settings.Default.release;
            screanPath = UserConfigHelper.GetValue(pathToConfig, "screenshot");
            processName = UserConfigHelper.GetValue(pathToConfig, "process");
            release = UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_");
            steepNum = steepTextBox.Text.Trim().Replace(" ", "_");
            testNum = testTextBox.Text.Trim().Replace(" ", "_");
            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screanPath + "\\" + release + "\\" + testNum);
                screanPath += "\\" + release + "\\" + testNum + "\\" + "Шаг_" + steepNum + ".png";

                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(200);
                
                if (timerCB.Checked == true)
                {
                    Thread.Sleep(5000);
                    timerCB.Checked = false;
                }

                //if (Settings.Default.typeScreen == 1)
                if (UserConfigHelper.GetValue(pathToConfig, "typeScreen") == "1")
                {
                    ScreenshotHelper.screenProcessWindow(screanPath, processName, testNum, steepNum);
                }
                //else if (Settings.Default.typeScreen == 2)
                else if (UserConfigHelper.GetValue(pathToConfig, "typeScreen") == "2")
                {
                    ScreenshotHelper.screenFullWindow(screanPath, testNum, steepNum);
                }
                resultTextBox.Text = "Скриншот теста № " + testNum + " 'Шаг " + steepNum + "' готов";
                linkToPaint.Visible = true;

                this.WindowState = FormWindowState.Normal;
                steepTextBox.Text = null;
                //screanPath = Settings.Default.screenshot;
                //screanPath = UserConfigHelper.GetValue(pathToConfig, "screenshot");
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

                    if (logRB.Checked == Enabled)
                        browserGB.Visible = false;
                    else
                        browserGB.Visible = true;
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
                //StreamReader sr = new StreamReader(Settings.Default.conf);
                StreamReader sr = new StreamReader(UserConfigHelper.GetValue(pathToConfig, "conf"));
                line = sr.ReadLine();
                while(line != null)
                {
                    if(line == "<"+resultText+">")
                    {
                        line = sr.ReadLine().Trim();
                        while (line != "</" + resultText + ">")
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
            Button btn = (Button) sender;
            //StreamReader sr1 = new StreamReader(Settings.Default.conf);
            StreamReader sr1 = new StreamReader(UserConfigHelper.GetValue(pathToConfig, "conf"));
            line = sr1.ReadLine();
            while (line != null)
            {
                if (line == "<" + resultText + ">")
                {
                    line = sr1.ReadLine();
                    while (line != "</" + resultText + ">")
                    {
                        subLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (subLine[0] == btn.Text)
                        {
//                            Clipboard.SetText(subLine[1]);
                            Process.Start(processGetName(), subLine[1]);
                        }
                        line = sr1.ReadLine();
                    }
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
        // Открытие окна "Добавление"
        private void добавлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            resultButtonPane.Controls.Clear();
            form3.Show();
        }
        // Открытие окна "Компактный вид"
        private void компактныйтолькоСкриншотыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form4 form4 = new Form4();

            form4.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        //
        // Получение процесса для "кнопки"
        private string processGetName()
        {
            string processName;

            if (logRB.Checked == Enabled)
                processName = UserConfigHelper.GetValue(pathToConfig, "pathExplorer");
            else if (IEexplorerRB.Checked == Enabled)
                    processName = UserConfigHelper.GetValue(pathToConfig, "pathIE");
                 else
                    processName = UserConfigHelper.GetValue(pathToConfig, "pathChrome");
            return processName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UserConfigHelper.GetValue(pathToConfig, "pathPaint"), screanPath);
        }
        //
    }
}