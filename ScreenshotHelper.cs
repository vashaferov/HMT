using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI.Xaml;


namespace HMT
{
    public class ScreenshotHelper
    {

        static string pathToConfig = pathHelper.GetPathToUserSF() + Environment.UserName + ".txt";

        // Скриншот монитора
        public static void screenFullWindow(String screanPath, String testNum, String steepNum)
        {
            var monitorLocetionBeChanged = UserConfigHelper.GetValue(pathToConfig, "monitorLocetion");
            var g1 = Regex.Replace(monitorLocetionBeChanged, @"[\{\}a-zA-Z=]", "").Split(',');
            Point point = new Point(int.Parse(g1[0]), int.Parse(g1[1]));

            var monitorSizeBeChanged = UserConfigHelper.GetValue(pathToConfig, "monitorSize");
            var g = Regex.Replace(monitorSizeBeChanged, @"[\{\}a-zA-Z=]", "").Split(',');

            int width = int.Parse(g[0]);
            int height = int.Parse(g[1]);

            Bitmap printscreen = new Bitmap(width, height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(point, new Point(0, 0), printscreen.Size);

            if (UserConfigHelper.GetValue(pathToConfig, "numOnScreen") == "True")
                numOnScreen(graphics, testNum, steepNum);
            
            printscreen.Save(screanPath, ImageFormat.Png);                           
  
            GC.Collect();
        }
        //
        // Номер теста и шага на скриншоте
        private static void numOnScreen(Graphics graphics, string testNum, string steepNum)
        {
            graphics.DrawRectangle(new Pen(Color.Black, 50), 0, 0, 422, 10);
            graphics.DrawRectangle(new Pen(Color.White, 50), 0, 0, 420, 8);
            graphics.DrawString("Тест № " + testNum + " Шаг № " + steepNum, new Font("Verdana", (float)20), new SolidBrush(Color.Red), 0, 0);
        }
        //
        // Создание архива
        public static void createZip (string path, string testNum)
        {
            string extractPath = path + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip";
            ZipFile.CreateFromDirectory(path + testNum, extractPath);
            string newPath = path + testNum + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip";
            if (!File.Exists(newPath))
                File.Move(extractPath, newPath);
            else
            {
                File.Delete(newPath);
                File.Move(extractPath, newPath);
            }                
        }
        //
    }
}
