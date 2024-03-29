﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HMT
{
    public partial class mainForm : Form
    {

        string steepNum;
        string testNum;
        string screenPath;
        string release;
        string pathToConfig = Directory.GetCurrentDirectory() + "\\" + Environment.UserName + ".txt";
        //string pathToConfig = pathHelper.GetPathToUserSF() + Environment.UserName + ".txt";


        public mainForm()
        {
            TopMost = true;
            InitializeComponent();
            UserConfigHelper.CheckConfig(Environment.UserName);
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

                if (!File.Exists(screenPath))
                {
                    this.WindowState = FormWindowState.Minimized;
                    Thread.Sleep(200);

                    if (timerCB_min.Checked == true)
                    {
                        Thread.Sleep(5000);
                        timerCB_min.Checked = false;
                    }

                    ScreenshotHelper.screenFullWindow(screenPath, testNum, steepNum);
                    resultL.Text = "Скриншот 'Шаг " + steepNum + "' готов";
                    linkToPaint.Visible = true;
                }
                else
                {
                    if (MessageBox.Show("Скриншот существует\nПерезаписать?", "Скриншот", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.WindowState = FormWindowState.Minimized;
                        Thread.Sleep(200);

                        if (timerCB_min.Checked == true)
                        {
                            Thread.Sleep(5000);
                            timerCB_min.Checked = false;
                        }

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
            Process.Start("mspaint.exe", screenPath);
        }
        //
        // Создание архива
        private void zipButtonFM_Click(object sender, EventArgs e)
        {
            if (testNumTB.Text != null && testNumTB.Text != "")
            {
                screenPath = UserConfigHelper.GetValue(pathToConfig, "screenshot") + "\\" + UserConfigHelper.GetValue(pathToConfig, "release").Replace(" ", "_") + "\\";
                if (ScreenshotHelper.createZip(screenPath, testNumTB.Text.Trim().Replace(" ", "_")))
                {
                    resultL.Text = "Архив для теста " + testNumTB.Text + " создан";
                    Process.Start("explorer.exe", screenPath + testNumTB.Text);
                    testNumTB.Text = null;
                    steepNumTB.Text = null;
                    linkToPaint.Visible = false;
                }
                else
                {
                    resultL.Text = "Архив для теста " + testNumTB.Text + " не создан";
                }
            }
            else
            {
                resultL.Text = "Не указан номер теста";
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
        }
        //
        // Открытие окна "Настройки"
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            settingsForm form2 = new settingsForm();
            form2.Show();
        }
        //
        // Открытие окна "Справка"
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.Show();
        }
        //

    }
}
