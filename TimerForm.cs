using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Documents;

namespace HMT
{
    public partial class TimerForm : Form
    {
        DateTime date = new DateTime(0, 0);
        DateTime date2 = new DateTime(0, 0);
        public TimerForm()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            date = date.AddSeconds(1);
            label1.Text = date.ToString("mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {            
            date2 = date2.AddSeconds(1);
            label2.Text = date2.ToString("mm:ss");
        }

        private object changeStatusRB()
        {
            if (radioButton2.Checked == true)
            {
                timer1.Enabled = false;
                return timer2;
            }
            else
            {
                timer2.Enabled = false;
                return timer1;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)changeStatusRB();
            if (startButton.Text == "Старт")
            {
                timer.Start();
                startButton.Text = "Пауза";
            }
            else
            {
                timer.Enabled = false;
                startButton.Text = "Старт";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(testTB.Text != null && testTB.Text != "")
            {
                string screenPath = UserConfigHelper.GetValue(pathHelper.GetPathToUserSF() + Environment.UserName + ".txt", "screenshot").Replace(" ", "_");

                timer1.Enabled = false;
                timer2.Enabled = false;
                startButton.Text = "Старт";

                Directory.CreateDirectory(screenPath + "\\Time\\");
                try
                {
                    StreamWriter writer = new StreamWriter(screenPath + "\\Time\\" + DateTime.Today.ToString("d") + ".txt", true);
                    writer.WriteLineAsync("Тест: " + testTB.Text + "\nПотрачено на подготовку ТД: " + label1.Text + "\nПотрачено на прохождение теста: " + label2.Text + "\n");
                    writer.Close();
                    
                    timer1.Stop();
                    timer2.Stop();
                    date = new DateTime(0, 0);
                    date2 = new DateTime(0, 0);
                    label1.Text = "00:00";
                    label2.Text = "00:00";
                    testTB.Text = null;
                }
                catch
                {
                    MessageBox.Show("Проблема при созданни файла", "Ошибка");
                }
            }
            else
                MessageBox.Show("Введите номер теста", "Ошибка");
        }
    }
}
