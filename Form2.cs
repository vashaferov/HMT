using System.DirectoryServices.ActiveDirectory;
using static System.Net.Mime.MediaTypeNames;

namespace HMT
{
    public partial class Form2 : Form
    {
        public string screenshotP;
        public string configP;
        public string processP;
        string pathToConfig = pathHelper.GetPathToUserSF() + Environment.UserName + ".txt";

        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            screenPathTB.Text = UserConfigHelper.GetValue(pathToConfig, "screenshot");
            configPathTB.Text = UserConfigHelper.GetValue(pathToConfig, "conf");
            releaseTB.Text = UserConfigHelper.GetValue(pathToConfig, "release");

            if (UserConfigHelper.GetValue(pathToConfig, "numOnScreen") == "True")
                numOnScreenPosRB.Checked = true;
            else
                numOnScreenNegRB.Checked = true;

            if (UserConfigHelper.GetValue(pathToConfig, "monitor") == "main")
                mainMonitor.Checked = true;
            else
                primaryMonitor.Checked = true;

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
            Form1 form1= new Form1();
            if (screenPathTB.Text == "" || configPathTB.Text == "" || releaseTB.Text == "")
                MessageBox.Show("Поля не заполнены!", "Настройки", MessageBoxButtons.OK);
            else
            {
                UserConfigHelper.SaveValue(pathToConfig, "screenshot", screenPathTB.Text);
                UserConfigHelper.SaveValue(pathToConfig, "conf", configPathTB.Text);
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

            } else if (primaryMonitor.Checked == Enabled)
            {
                UserConfigHelper.SaveValue(pathToConfig, "monitor", "primary");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                configPathTB.Text = openFileDialog1.FileName;
        }
        //
    }
}