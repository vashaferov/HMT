using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Shapes;

namespace HMT
{
    public class UserConfigHelper
    {
        string line;

        public string GetValue(string file, string name)
        {
            StreamReader sr = new StreamReader(file);

            line = sr.ReadLine();
            while (line != null)
            {
                if (line == "<" + name + ">")
                {
                    line = sr.ReadLine();
                    break;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return line; 
        }

        public string SabeValue(string file, string name)
        {
            StreamReader sr = new StreamReader(file);

            line = sr.ReadLine();
            while (line != null)
            {
                if (line == "<" + name + ">")
                {
                    line = sr.ReadLine();
                    break;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return line;
        }

        public void replaceline(String section, String endSection, String newLine)
        {
            StreamReader sr = new StreamReader(Settings.Default.conf);
            line = sr.ReadToEnd();
            line = line.Replace(section,   " " + newLine + "\n" + endSection);
            sr.Close();

            StreamWriter sw = new StreamWriter(Settings.Default.conf);

            sw.Write(line);
            sw.Close();
        }
    }
}
