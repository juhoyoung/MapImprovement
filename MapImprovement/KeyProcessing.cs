using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MapImprovement
{
    class KeyProcessing
    {
        public static KeyProcessing kProcessing = new KeyProcessing(); // 싱글톤
        static public ViewForm viewForm;
        static public CanvasForm canvasForm;
        static bool KeyDown = false;
        static int vkCode;

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);




        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_ALTDOWN = 0x104;
        const int WM_KEYUP = 0x101;
        const int WM_ALTUP = 0x105;

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;


        public void getCanvasForm(CanvasForm cForm)
        {
            canvasForm = cForm;
        }

        public void getViewForm(ViewForm vForm)
        {
            viewForm = vForm;
        }

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {

            Console.WriteLine(code + " W=" + wParam + " I=" + Marshal.ReadInt32(lParam));

            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && KeyDown == false)
            {
                vkCode = Marshal.ReadInt32(lParam);

                if (vkCode.ToString() == "162") // ctrl 키 눌렀을때
                {
                    KeyDown = true;
                }

                //return (IntPtr)1;
            }
            else if (code >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                vkCode = Marshal.ReadInt32(lParam);

                if (vkCode.ToString() == "162") // ctrl 키 뗐을때
                {
                    KeyDown = false;
                }

                //return (IntPtr)1;
            }




            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && KeyDown == true) // ctrl 키 누르고있을때
            {
                vkCode = Marshal.ReadInt32(lParam);

                if (vkCode.ToString() == "81")  // q 누를시 그리는 판 숨김
                {
                    try
                    {
                        canvasForm.SetVisibleForm();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }


                if (vkCode.ToString() == "87") // w 누를시 그려진 판 숨김
                {
                    canvasForm.SetVisibleForm();
                    viewForm.SetVisibleForm();
                    return hhook;
                }


                if (vkCode.ToString() == "32")
                {
                    viewForm.Refresh();
                }
            }

            return CallNextHookEx(hhook, code, (int)wParam, lParam);

        }


    }
}
