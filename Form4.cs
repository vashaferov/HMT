using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMT
{
    public partial class Form4 : Form
    {

        string processName;
        string steepNum;
        string testNum;
        string screanPath;
        string release;


        public Form4()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screanPath = Settings.Default.screenshot;
            processName = Settings.Default.process;
            release = Settings.Default.release;
            steepNum = steepNumTB.Text.Trim();
            testNum = testNumTB.Text.Trim();
            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screanPath + "\\" + release + "\\" + testNum);
                screanPath += "\\" + release + "\\" + testNum + "\\" + "Шаг " + steepNum + ".png";

                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(200);

                if (timerCB_min.Checked == true)
                {
                    Thread.Sleep(5000);
                    timerCB_min.Checked = false;
                }

                if (Settings.Default.typeScreen == 1)
                {
                    ScreenshotHelper.screenProcessWindow(screanPath, processName, testNum, steepNum);
                }
                else if (Settings.Default.typeScreen == 2)
                {
                    ScreenshotHelper.screenFullWindow(screanPath, testNum, steepNum);
                }
                resultL.Text = "Скриншот теста № " + testNum + " 'Шаг " + steepNum + "' готов";

                this.WindowState = FormWindowState.Normal;
                steepNumTB.Text = null;
                screanPath = Settings.Default.screenshot;
            }
            else
            {
                resultL.Text = "Не указан нормер шага или номер теста";
            }
        }
    }
}
