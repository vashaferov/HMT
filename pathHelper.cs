using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Shapes;

namespace HMT
{
    internal class pathHelper
    {

        static string line;

        public static string GetPathToUserSF()
        {
            StreamReader sr = new StreamReader("pathHelper.txt");

            line = sr.ReadLine();
            while (line != null)
            {
                if (line == "<pathToConfig>")
                {
                    line = sr.ReadLine();
                    break;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return line;
        }

    }
}
