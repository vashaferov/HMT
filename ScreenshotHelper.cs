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
        //Для скриншота процесса
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;
        }
        //

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

            if (!File.Exists(screanPath))
                printscreen.Save(screanPath, ImageFormat.Png);
            else
                if (MessageBox.Show("Скриншот существует\nПерезаписать?", "Скриншот", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    printscreen.Save(screanPath, ImageFormat.Png);
                else
                    return;

            GC.Collect();
        }
        //
        // Номер теста и шага на скриншоте
        private static void numOnScreen(Graphics graphics, string testNum, string steepNum)
        {
            graphics.DrawRectangle(new Pen(Color.Black, 100), 0, 0, 172, 17);
            graphics.DrawRectangle(new Pen(Color.White, 100), 0, 0, 170, 15);
            graphics.DrawString("Тест № " + testNum + "\nШаг № " + steepNum, new Font("Verdana", (float)20), new SolidBrush(Color.Red), 0, 0);
        }
        //
        // Создание архива
        public static void createZip (string path, string testNum)
        {
            string extractPath = path + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip";
            ZipFile.CreateFromDirectory(path + testNum, extractPath);
            string newPath = path + testNum + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip";
            if (!File.Exists(path + testNum + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip"))
                File.Move(extractPath, path + testNum + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip");
            else
            {
                File.Delete(newPath);
                File.Move(extractPath, path + testNum + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip");
            }                
        }
        //
    }
}
