using System.Windows.Forms;

namespace HMT
{
    public class UserConfigHelper
    {
        static string line;
        static string pathToConfig = Directory.GetCurrentDirectory() + "\\";

        public static void CheckConfig(string nameUser)
        {
            if (!File.Exists(pathToConfig + nameUser + ".txt"))
            {
                File.Copy("dcf.txt", pathToConfig + nameUser + ".txt");
                Form2 form2 = new Form2();
                Thread.Sleep(1000);
                form2.Show();
            }
        }

        public static string GetValue(string file, string name)
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

        public static void SaveValue(string file, string section, string newLine)
        {
            StreamReader sr = new StreamReader(file);
            line = sr.ReadToEnd();
            line = line.Replace(GetValue(file, section), newLine);
            sr.Close();

            StreamWriter sw = new StreamWriter(file);
            sw.Write(line);
            sw.Close();
        }
    }
}
