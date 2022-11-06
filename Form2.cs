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

            // Проверка на наличие второго монитора, если его нет, то передаются координаты основного монитора 
            int screens = Screen.AllScreens.Length;
            if (screens == 1)
            {
                primaryMonitor.Visible = false;
                mainMonitor.Checked = true;
                var resulution1 = Screen.PrimaryScreen.Bounds.Size;
                var resulution2 = Screen.PrimaryScreen.Bounds.Location;

                UserConfigHelper.SaveValue(pathToConfig, "monitorSize", resulution1.ToString());
                UserConfigHelper.SaveValue(pathToConfig, "monitorLocetion", resulution2.ToString());
                UserConfigHelper.SaveValue(pathToConfig, "typeScreen", "2");
            }
            //
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();

            UserConfigHelper.SaveValue(pathToConfig, "screenshot", screenPathTB.Text);
            UserConfigHelper.SaveValue(pathToConfig, "conf", configPathTB.Text);
            UserConfigHelper.SaveValue(pathToConfig, "release", releaseTB.Text);
            this.Close();
            MessageBox.Show("Настройки сохранены", "Настройки", MessageBoxButtons.OK);
        }
 
        // Выбор монитора для скриншота
        private void monitor_CheckedChanged(object sender, EventArgs e)
        {
            if (mainMonitor.Checked == Enabled)
            {
                var resulution1 = Screen.AllScreens[0].Bounds.Size;
                var resulution2 = Screen.AllScreens[0].Bounds.Location;

                UserConfigHelper.SaveValue(pathToConfig, "monitorSize", resulution1.ToString());
                UserConfigHelper.SaveValue(pathToConfig, "monitorLocetion", resulution2.ToString());

            } else if (primaryMonitor.Checked == Enabled)
            {
                var resulution1 = Screen.AllScreens[1].Bounds.Size;
                var resulution2 = Screen.AllScreens[1].Bounds.Location;

                UserConfigHelper.SaveValue(pathToConfig, "monitorSize", resulution1.ToString());
                UserConfigHelper.SaveValue(pathToConfig, "monitorLocetion", resulution2.ToString());
            }


        }

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
    }
}
