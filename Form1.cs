
using System.Diagnostics;

namespace HMT

{
    public partial class Form1 : Form
    {
        string subResultText = "";
        string resultText = "";
        string line;
        string[] subLine;
        string steepNum;
        string testNum;
        string screenPath;
        string release;
        string userName = Environment.UserName;
        string pathToConfig = pathHelper.GetPathToUserSF() + Environment.UserName + ".txt";

        public Form1()
        {
            InitializeComponent();
            // Проверка на первый запуск
            //try
            //{
                UserConfigHelper.CheckConfig(userName);
            //} catch (Exception e)
            //{
            //    MessageBox.Show("Ошибка при полчении пути для сохранения файла конфига.");
            //}  
            //
        }
        //Создание скриншота
        private void screanshotButton_Click(object sender, EventArgs e)
        {
            resultText = "";
            screenPath = UserConfigHelper.GetValue(pathToConfig, "screenshot");
            release = UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_");
            steepNum = steepTextBox.Text.Trim().Replace(" ", "_");
            testNum = testTextBox.Text.Trim().Replace(" ", "_");
            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screenPath + "\\" + release + "\\" + testNum);
                screenPath += "\\" + release + "\\" + testNum + "\\" + "Шаг_" + steepNum + ".png";

                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(200);
                
                if (timerCB.Checked == true)
                {
                    Thread.Sleep(5000);
                    timerCB.Checked = false;
                }

                ScreenshotHelper.screenFullWindow(screenPath, testNum, steepNum);

                resultTextBox.Text = "Скриншот теста № " + testNum + " 'Шаг " + steepNum + "' готов";
                linkToPaint.Visible = true;

                this.WindowState = FormWindowState.Normal;
                steepTextBox.Text = null;
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
            else
            {
                if (IEexplorerRB.Checked == Enabled)
                    processName = UserConfigHelper.GetValue(pathToConfig, "pathIE");
                else
                {
                    if (Directory.Exists(UserConfigHelper.GetValue(pathToConfig, "pathChrome")))
                        processName = UserConfigHelper.GetValue(pathToConfig, "pathChrome");
                    else
                        processName = UserConfigHelper.GetValue(pathToConfig, "pathChromeX86");
                } 
            }  
            return processName;
        }
        // Открытие последнего скриншота в Paint
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UserConfigHelper.GetValue(pathToConfig, "pathPaint"), screenPath);
        }
        //
        // Создание архива
        private void button1_Click(object sender, EventArgs e)
        {
            screenPath = UserConfigHelper.GetValue(pathToConfig, "screenshot") + "\\" + UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_") + "\\";
            ScreenshotHelper.createZip(screenPath, testTextBox.Text.Trim().Replace(" ", "_"));
        }
        //
    }
}