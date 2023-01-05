//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace HMT
//{
//    public sealed class GlobalHook : IDisposable
//    {
//        private static class WinAPI
//        {
//            public static class Kernel32
//            {
//                [DllImport("kernel32.dll")]
//                public static extern IntPtr LoadLibrary(string lpFileName);
//            }
//            public static class User32
//            {
//                public struct KeyboardHookStruct
//                {
//                    public uint VKCode;
//                    public uint ScanCode;
//                    public uint Flags;
//                    public uint Time;
//                    public IntPtr dwExtaInfo;
//                }


//            }
//        }
//    }
//}
