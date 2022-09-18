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
                MessageBox.Show("� ���������� ���������� �������:\n" +
                    "- '���� ��� ���������� ����������' - ������� ���������� ��� ���������� ����������;\n" +
                    "- '���� � ����� �������' - �������� ������ ��� ����� �����;\n" +
                    "- '�������� ��������' - ������� ������� ������� ����� �������������. �������� ����� ���������� ����� '��������� �����';", "����������", MessageBoxButtons.OK);
                Settings.Default.firstStart = false;
                Settings.Default.Save();
            }
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
            screanPath = Settings.Default.screenshot;
            processName = Settings.Default.process;
            release = Settings.Default.release;
            steepNum = steepTextBox.Text.Trim();
            testNum = testTextBox.Text.Trim();
            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screanPath + "\\" + release + "\\" + testNum);
                screanPath += "\\" + release + "\\" + testNum + "\\" + "��� " + steepNum + ".png";

                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(200);

                if (Settings.Default.typeScreen == 1)
                {
                    ScreenshotHelper.screenProcessWindow(screanPath, processName, testNum, steepNum);
                }
                else if (Settings.Default.typeScreen == 2)
                {
                    ScreenshotHelper.screenFullWindow(screanPath, testNum, steepNum);
                }
                resultTextBox.Text = "�������� ����� � " + testNum + " '��� " + steepNum + "' �����";

                this.WindowState = FormWindowState.Normal;
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
            StreamReader sr1 = new StreamReader(Settings.Default.conf);
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
                            Clipboard.SetText(subLine[1]);
                        }
                        line = sr1.ReadLine();
                    }
                }
                line = sr1.ReadLine();
            }
            sr1.Close();

            resultTextBox.Text = "������ ��� " + btn.Text + " �����������";
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

        private void �������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form4 form4 = new Form4();

            form4.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        //
    }
}