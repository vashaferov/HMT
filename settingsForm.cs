using System.DirectoryServices.ActiveDirectory;
using Windows.UI.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace HMT
{
    public partial class settingsForm : Form
    {
        public string screenshotP;
        public string configP;
        public string processP;
        string pathToConfig = Directory.GetCurrentDirectory() + "\\" + Environment.UserName + ".txt";

        public settingsForm()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            screenPathTB.Text = UserConfigHelper.GetValue(pathToConfig, "screenshot");
            releaseTB.Text = UserConfigHelper.GetValue(pathToConfig, "release");

            if (UserConfigHelper.GetValue(pathToConfig, "numOnScreen") == "True")
                numOnScreenPosRB.Checked = true;
            else
                numOnScreenNegRB.Checked = true;

            if (UserConfigHelper.GetValue(pathToConfig, "monitor") == "main")
                mainMonitor.Checked = true;
            else if (UserConfigHelper.GetValue(pathToConfig, "monitor") == "primary")
                primaryMonitor.Checked = true;
            else
            {
                processRB.Checked = true;
                processCB.Text = UserConfigHelper.GetValue(pathToConfig, "procSelectedItem");

                switch (UserConfigHelper.GetValue(pathToConfig, "procSelectedItem"))
                {
                    case "mstsc":
                        processCB.Text = "Удаленный рабочий стол";
                        break;
                    case "CDViewer":
                        processCB.Text = "Citrix";
                        break;
                    case "iexplorer":
                        processCB.Text = "Internet Explorer";
                        break;
                    case "chrome":
                        processCB.Text = "Chrome";
                        break;


                }
            }

            // Проверка на наличие второго монитора, если его нет, то передаются координаты основного монитора 
            int screens = Screen.AllScreens.Length;
            if (screens == 1)
            {
                UserConfigHelper.SaveValue(pathToConfig, "monitor", "main");
            }
            //
        }
        // Сохранение настроек
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (screenPathTB.Text == "" || releaseTB.Text == "")
                MessageBox.Show("Поля не заполнены!", "Настройки", MessageBoxButtons.OK);
            else
            {
                UserConfigHelper.SaveValue(pathToConfig, "screenshot", screenPathTB.Text);
                UserConfigHelper.SaveValue(pathToConfig, "release", releaseTB.Text);
                this.Close();
                MessageBox.Show("Настройки сохранены", "Настройки", MessageBoxButtons.OK);
            }
        }
        //
        // Выбор монитора для скриншота
        private void monitor_CheckedChanged(object sender, EventArgs e)
        {
            if (mainMonitor.Checked == Enabled)
            {
                UserConfigHelper.SaveValue(pathToConfig, "monitor", "main");

            }
            else if (primaryMonitor.Checked == Enabled)
            {
                UserConfigHelper.SaveValue(pathToConfig, "monitor", "primary");
            }
            else if (processRB.Checked == Enabled)
            {
                UserConfigHelper.SaveValue(pathToConfig, "monitor", "process");
            }
        }
        //
        // Проверка активности тригеров "Номер теста на скриншоте"
        private void numOnScreenRB_CheckedChanged(object sender, EventArgs e)
        {
            if (numOnScreenPosRB.Checked == Enabled)
            {
                UserConfigHelper.SaveValue(pathToConfig, "numOnScreen", "True");
            }
            else
            {
                UserConfigHelper.SaveValue(pathToConfig, "numOnScreen", "False");
            }
        }
        //
        // Кнопки "Обзор"
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                screenPathTB.Text = folderBrowserDialog1.SelectedPath;
        }

        private void processCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = processCB.SelectedItem.ToString();
            switch (selected)
            {
                case "Удаленный рабочий стол": 
                    UserConfigHelper.SaveValue(pathToConfig, "procSelectedItem", "mstsc"); 
                    break;
                case "Citrix":
                    UserConfigHelper.SaveValue(pathToConfig, "procSelectedItem", "CDViewer");
                    break;
                case "Internet Explorer":
                    UserConfigHelper.SaveValue(pathToConfig, "procSelectedItem", "iexplorer");
                    break;
                case "Chrome":
                    UserConfigHelper.SaveValue(pathToConfig, "procSelectedItem", "chrome");
                    break;


            }
        }
        //
    }
}