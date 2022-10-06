using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

        // Скриншот процесса
        public static void screenProcessWindow(String screanPath, String processName, String testNum, String steepNum)
        {
            try
            {
                var process = Process.GetProcessesByName(processName).FirstOrDefault();
                var hwnd = process.MainWindowHandle;
                GetWindowRect(hwnd, out var rect);

                using (var printscreen = new Bitmap(rect.Right - rect.Left, rect.Bottom - rect.Top))
                {
                    using (var graphics = Graphics.FromImage(printscreen))
                    {
                        var hdcBitmap = graphics.GetHdc();
                        PrintWindow(hwnd, hdcBitmap, 0);
                        graphics.ReleaseHdc(hdcBitmap);
                        if (Settings.Default.numOnScreen == true)
                            numOnScreen(graphics, testNum, steepNum);
                    }

                    printscreen.Save(screanPath, ImageFormat.Png);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Не указан процесс", "Ошибка", MessageBoxButtons.OK);
            }
        }
        //
        // Скриншот монитора
        public static void screenFullWindow(String screanPath, String testNum, String steepNum)
        {
            int width = Settings.Default.monitorSize.Width;
            int height = Settings.Default.monitorSize.Height;
            Point point = Settings.Default.monitorLocetion;

            Bitmap printscreen = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(point, new Point(0, 0), printscreen.Size);

            if (Settings.Default.numOnScreen == true)
                numOnScreen(graphics, testNum, steepNum);

            printscreen.Save(screanPath, ImageFormat.Png);
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
    }
}
