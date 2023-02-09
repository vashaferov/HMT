using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HMT
{
    public partial class Form4 : Form
    {

        string steepNum;
        string testNum;
        string screenPath;
        string release;
        string pathToConfig = pathHelper.GetPathToUserSF() + Environment.UserName + ".txt";


        public Form4()
        {
            TopMost = true;
            InitializeComponent();
        }
        // Создание скриншота
        private void button1_Click(object sender, EventArgs e)
        {
            screenPath = UserConfigHelper.GetValue(pathToConfig, "screenshot").Replace(" ", "_");
            release = UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_");
            steepNum = steepNumTB.Text.Trim().Replace(" ", "_").Replace(",", ".");
            testNum = testNumTB.Text.Trim().Replace(" ", "_");

            if (steepNum != "" && testNum != "")
            {
                Directory.CreateDirectory(screenPath + "\\" + release + "\\" + testNum);
                screenPath += "\\" + release + "\\" + testNum + "\\" + "Шаг_" + steepNum + ".png";

                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(200);

                if (timerCB_min.Checked == true)
                {
                    Thread.Sleep(5000);
                    timerCB_min.Checked = false;
                }

                if (!File.Exists(screenPath))
                {
                    ScreenshotHelper.screenFullWindow(screenPath, testNum, steepNum);
                    resultL.Text = "Скриншот теста № " + testNum + " 'Шаг " + steepNum + "' готов";
                    linkToPaint.Visible = true;
                }
                else
                {
                    if (MessageBox.Show("Скриншот существует\nПерезаписать?", "Скриншот", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ScreenshotHelper.screenFullWindow(screenPath, testNum, steepNum);
                        resultL.Text = "Скриншот теста № " + testNum + " 'Шаг " + steepNum + "' готов";
                        linkToPaint.Visible = true;
                    }
                }
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                resultL.Text = "Не указан нормер шага или номер теста";
            }
        }
        //
        // Открытие скриншота в Paint
        private void linkToPaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UserConfigHelper.GetValue(pathToConfig, "pathPaint"), screenPath);
        }
        //
        // Создание архива
        private void zipButtonFM_Click(object sender, EventArgs e)
        {
            if (testNumTB.Text != null && testNumTB.Text != "")
            {
                screenPath = UserConfigHelper.GetValue(pathToConfig, "screenshot") + "\\" + UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_") + "\\";
                ScreenshotHelper.createZip(screenPath, testNumTB.Text.Trim().Replace(" ", "_"));
                resultL.Text = "Архив для теста " + testNumTB.Text + " создан";
                testNumTB.Text = null;
                steepNumTB.Text = null;
                linkToPaint.Visible = false;
            } else
            {
                resultL.Text = "Не указан нормер шага или номер теста";
            }
        }
        //
        // Хоткеи
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            double steepD;
            // ХК скрин "Enter"
            if (e.KeyValue == (char)Keys.Enter)
                button1.PerformClick();
            // ХК создание архива "Ctrl + Shift"
            if (e.Control && e.Shift)
                zipButtonFM.PerformClick();
            // ХК увеличить шаг "Ctrl + U"
            if (e.Control && e.KeyValue == (char)Keys.U)
            {
                if (steepNumTB.Text != null && steepNumTB.Text != "")
                {
                    steepD = Double.Parse(steepNumTB.Text) + 1;
                    steepNumTB.Text = steepD.ToString();
                }
            }
            // ХК уменьшить шаг "Ctrl + J"
            if (e.Control && e.KeyValue == (char)Keys.J)
            {
                if (steepNumTB.Text != null && steepNumTB.Text != "" && steepNumTB.Text != "0")
                {
                    steepD = Double.Parse(steepNumTB.Text) - 1;
                    steepNumTB.Text = steepD.ToString();
                }
            }
        }
        //
       
    }
}
