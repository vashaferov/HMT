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

namespace HMT
{
    public partial class Form3 : Form
    {
        string line;
        string resultText;
        string pathToConfig = pathHelper.GetPathToUserSF() + Environment.UserName + ".txt";

        public Form3()
        {
            InitializeComponent();
        }
      
        //Получение нажатого RB в "раздел"
        private void sectionGB_mouseClick(object sender, EventArgs e)
        {
            foreach (RadioButton rb in sectionGB.Controls.OfType<RadioButton>())
            {
                if (rb.Checked == true)
                {
                    resultText = rb.Text;
                }
            }
        }
        //
        // Сохранение новых пунктов
        private void button1_Click(object sender, EventArgs e)
        {
            if (linkRB.Checked == true || logRB.Checked == true)
            {
                if (nameTB.Text != "" && nextTB.Text != "" && realTB.Text != "" && intTB.Text != "")
                {
                    replaceline("<Next_" + resultText + ">", "</Next_" + resultText + ">", nextTB.Text);
                    replaceline("<Real_" + resultText + ">", "</Real_" + resultText + ">", realTB.Text);
                    replaceline("<Int_" + resultText + ">", "</Int_" + resultText + ">", intTB.Text);

                    Form1 form1 = new Form1();
                    this.Close();
                    MessageBox.Show("Настройки сохранены", "Настройки", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Не выбран раздел!", "Ошибка", MessageBoxButtons.OK);
        }
        public void replaceline(String section, String endSection, String newLine)
        {
            StreamReader sr = new StreamReader(UserConfigHelper.GetValue(pathToConfig, "conf"));
            
            line = sr.ReadToEnd();
            line = line.Replace(endSection, nameTB.Text + " " + newLine + "\n" + endSection);
            sr.Close();

            StreamWriter sw = new StreamWriter(UserConfigHelper.GetValue(pathToConfig, "conf"));

            sw.Write(line);
            sw.Close();
        }
    }
}