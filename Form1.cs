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
            UserConfigHelper.CheckConfig(userName);
        }
        //�������� ���������
        private void screanshotButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = null;
            //pictureBox1.Image = null;
            linkToPaint.Visible = false;
            lastScreenLabel.Visible = false;
            screenPath = UserConfigHelper.GetValue(pathToConfig, "screenshot").Replace(" ", "_");
            release = UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_");
            steepNum = steepTextBox.Text.Trim().Replace(" ", "_").Replace(",", ".");
            testNum = testTextBox.Text.Trim().Replace(" ", "_");
            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screenPath + "\\" + release + "\\" + testNum);
                screenPath += "\\" + release + "\\" + testNum + "\\" + "���_" + steepNum + ".png";               
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(200);

                if (timerCB.Checked == true)
                {
                    Thread.Sleep(5000);
                    timerCB.Checked = false;
                }

                if (!File.Exists(screenPath))
                {
                    ScreenshotHelper.screenFullWindow(screenPath, testNum, steepNum);
                    resultTextBox.Text = "�������� ����� � " + testNum + " '��� " + steepNum + "' �����";
                    linkToPaint.Visible = true;
                    lastScreenLabel.Visible = true;
                    pictureBox1.Image = Image.FromFile(screenPath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                } else
                {
                    if (MessageBox.Show("�������� ����������\n������������?", "��������", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ScreenshotHelper.screenFullWindow(screenPath, testNum, steepNum);
                        resultTextBox.Text = "�������� ����� � " + testNum + " '��� " + steepNum + "' �����";
                        linkToPaint.Visible = true;
                        lastScreenLabel.Visible = true;
                        pictureBox1.Image = Image.FromFile(screenPath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    } else
                        pictureBox1.Image = null;
                }   
                this.WindowState = FormWindowState.Normal;                  
                                
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
        //��������� �������� RB � "������"
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
        //������ ����� � ��������, ��������� ������ �� ������, �������� "�����������"
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
                resultTextBox.Text = "������ ��� ������ �����";
            }

        }
        //
        // ������ �������� �� ������
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
        // �������� ���� "���������"
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        //
        // �������� ���� "����������"
        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            resultButtonPane.Controls.Clear();
            form3.Show();
        }
        // �������� ���� "���������� ���"
        private void �������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            Form4 form4 = new Form4();
            
            form4.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        //
        // ��������� �������� ��� "������"
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
                    processName = UserConfigHelper.GetValue(pathToConfig, "pathChrome");
                    if (!File.Exists(processName))
                    {
                        processName = processName.Replace("Program Files", "Program Files (x86)");
                    }                        
                } 
            }  
            return processName;
        }
        // �������� ���������� ��������� � Paint
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UserConfigHelper.GetValue(pathToConfig, "pathPaint"), screenPath);
        }
        //
        // �������� ������
        private void zipButton_Click(object sender, EventArgs e)
        {
            if (testTextBox.Text != null && testTextBox.Text != "")
            {
                screenPath = UserConfigHelper.GetValue(pathToConfig, "screenshot") + "\\" + UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_") + "\\";
                ScreenshotHelper.createZip(screenPath, testTextBox.Text.Trim().Replace(" ", "_"));
                resultTextBox.Text = "����� ��� ����� " + testTextBox.Text + " ������";
                linkToPaint.Visible = false;
                testTextBox.Text = null;
                steepTextBox.Text = null;
            } else
            {
                resultTextBox.Text = "�� ������ ������ ���� ��� ����� �����";
            }
            
        }
        //
        // �������� ���� "�������"
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.Show();
        }
        //
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            double steepD;
            // �� ����� "Enter"
            if (e.KeyValue == (char)Keys.Enter)
                screanshotButton.PerformClick();
            // �� �������� ������ "Ctrl + Enter"
            if (e.Control && e.Shift)
                zipButton.PerformClick();
            // �� ��������� ��� "Ctrl + U"
            if (e.Control && e.KeyValue == (char)Keys.U)
            {
                if (steepTextBox.Text != null && steepTextBox.Text != "")
                {
                    steepD = Double.Parse(steepTextBox.Text) + 1;
                    steepTextBox.Text = steepD.ToString();
                }
            }
            // �� ��������� ��� "Ctrl + J"
            if(e.Control && e.KeyValue == (char)Keys.J)
            {
                if (steepTextBox.Text != null && steepTextBox.Text != "" && steepTextBox.Text != "0")
                {
                    steepD = Double.Parse(steepTextBox.Text) - 1;
                    steepTextBox.Text = steepD.ToString();
                }
            }
            // �� ��������� ���. ��� "Ctrl + Y"
            //if (e.Control && e.KeyValue == (char)Keys.Y)
            //{
            //    if (steepTextBox.Text != null && steepTextBox.Text != "")
            //    {
            //        steepD = Double.Parse(steepTextBox.Text) + 0.1f;
            //        steepTextBox.Text = steepD.ToString("#.##");
            //    }
            //}
            //// �� ��������� ���. ��� "Ctrl + H"
            //if (e.Control && e.KeyValue == (char)Keys.H)
            //{
            //    if (steepTextBox.Text != null && steepTextBox.Text != "" && steepTextBox.Text != "0")
            //    {
            //        steepD = Double.Parse(steepTextBox.Text) - 0.1f;
            //        steepTextBox.Text = steepD.ToString("#.##");
            //    }
            //}
        }
    }
}