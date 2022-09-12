namespace HMT
{
    public partial class Form2 : Form
    {
        public string screenshotP;
        public string configP;
        public string processP;

        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            screenPathTB.Text = Settings.Default.screenshot;
            configPathTB.Text = Settings.Default.conf;
            processTB.Text = Settings.Default.process;
            releaseTB.Text = Settings.Default.release;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();

            Settings.Default.screenshot = screenPathTB.Text;
            Settings.Default.conf = configPathTB.Text;
            Settings.Default.process = processTB.Text;
            Settings.Default.release = releaseTB.Text;
            Settings.Default.Save();
            Settings.Default.Upgrade();
            this.Close();
            MessageBox.Show("Настройки сохранены", "Настройки", MessageBoxButtons.OK);
        }
        // Выбор метода создания скриншота
        private void menuScreenRB_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            processTB.Visible = false;
            groupBox2.Visible = false;

            if (menuProcessRB.Checked == Enabled)
            {
                label3.Visible = true;
                processTB.Visible = true;
                Settings.Default.typeScreen = 1;
                Settings.Default.Save();

            }
            // Проверка на наличие второго монитора, если его нет, то передаются координаты основного монитора 
            if (menuMonitorRB.Checked == Enabled)
            {
                groupBox2.Visible = true;
                int screens = Screen.AllScreens.Length;
                if (screens == 1)
                {
                    primaryMonitor.Visible = false;
                    mainMonitor.Checked = true;
                    var resulution1 = Screen.PrimaryScreen.Bounds.Size;
                    var resulution2 =  Screen.PrimaryScreen.Bounds.Location;
                    Settings.Default.monitorSize = resulution1;
                    Settings.Default.monitorLocetion = resulution2;
                    Settings.Default.typeScreen = 2;
                    Settings.Default.Save();
                }
            }
            //
        }
        //
        // Выбор монитора для скриншота
        private void monitor_CheckedChanged(object sender, EventArgs e)
        {
            if (mainMonitor.Checked == Enabled)
            {
                var resulution1 = Screen.AllScreens[0].Bounds.Size;
                var resulution2 = Screen.AllScreens[0].Bounds.Location;

                Settings.Default.monitorSize = resulution1;
                Settings.Default.monitorLocetion = resulution2;
                Settings.Default.typeScreen = 2;
                Settings.Default.Save();

            } else if (primaryMonitor.Checked == Enabled)
            {
                var resulution1 = Screen.AllScreens[1].Bounds.Size;
                var resulution2 = Screen.AllScreens[1].Bounds.Location;

                Settings.Default.monitorSize = resulution1;
                Settings.Default.monitorLocetion = resulution2;
                Settings.Default.typeScreen = 2;
                Settings.Default.Save();
            }

        }

        private void numOnScreenRB_CheckedChanged(object sender, EventArgs e)
        {
            if (numOnScreenPosRB.Checked == Enabled)
            {
                Settings.Default.numOnScreen = true;
            }
            else
            {
                Settings.Default.numOnScreen = false;
            }
            Settings.Default.Save();
        }
    }
}
