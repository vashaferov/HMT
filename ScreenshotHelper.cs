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
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Documents;

namespace HMT
{
    public class ScreenshotHelper
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;
        }

        static string pathToConfig = Directory.GetCurrentDirectory() + "\\" + Environment.UserName + ".txt";

        // Скриншот монитора
        public static void screenFullWindow(String screanPath, String testNum, String steepNum)
        {
            if (UserConfigHelper.GetValue(pathToConfig, "monitor") == "process")
            {
                var process = Process.GetProcessesByName(UserConfigHelper.GetValue(pathToConfig, "procSelectedItem")).FirstOrDefault();
                // не забудьте поверку ошибок: вдруг у вас не нашлось ни одного процесса?
                if (process != null)
                {
                    var hwnd = process.MainWindowHandle;
                    GetWindowRect(hwnd, out var rect);
                    using (var image = new Bitmap(rect.Right - rect.Left, rect.Bottom - rect.Top))
                    {
                        using (var graphics = Graphics.FromImage(image))
                        {
                            var hdcBitmap = graphics.GetHdc();
                            PrintWindow(hwnd, hdcBitmap, 0);
                            graphics.ReleaseHdc(hdcBitmap);
                        }

                        // тут у вас есть картинка, вы можете, например, сохранить её
                        image.Save(screanPath, ImageFormat.Png);
                    }
                
                } else
                    MessageBox.Show("Процесс не найден. Проверьте запущена ли нужная программа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int m;

                if (UserConfigHelper.GetValue(pathToConfig, "monitor") == "main")
                    m = 0;
                else
                    m = 1;

                var resulution2 = Screen.AllScreens[m].Bounds.Location;

                Bitmap printscreen = new Bitmap(Screen.AllScreens[m].Bounds.Width, Screen.AllScreens[m].Bounds.Height);

                Graphics graphics = Graphics.FromImage(printscreen as Image);
                graphics.CopyFromScreen(resulution2, new Point(0, 0), printscreen.Size);

                if (UserConfigHelper.GetValue(pathToConfig, "numOnScreen") == "True")
                    numOnScreen(graphics, testNum, steepNum);

                printscreen.Save(screanPath, ImageFormat.Png);
            }                             
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
        public static bool createZip (string path, string testNum)
        {
            bool flag = true;
            string extractPath = path + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip";
            string newPath = path + testNum + "\\Test_" + testNum + "_" + DateTime.Today.ToString("d") + ".zip";
            try
            {
                ZipFile.CreateFromDirectory(path + testNum, extractPath);
            } 
            catch (IOException e)
            {
                flag = false;
                MessageBox.Show("Открыт файл, который нужно добавить в архив. Закройте его, и запустите процесc повторно.\n" + e.Message + "", "Ошибка создания архива!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (flag)
            {
                
                if (!File.Exists(newPath))
                    File.Move(extractPath, newPath);
                else
                {
                    File.Delete(newPath);
                    File.Move(extractPath, newPath);
                }
                return true;
            }
            else
            {               
                File.Delete(extractPath);
                return false;
            }
                          
        }
        //
    }
}
