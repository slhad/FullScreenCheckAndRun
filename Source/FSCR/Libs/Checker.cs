using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

[StructLayout(LayoutKind.Sequential)]
public struct RECT
{
    public int Left;
    public int Top;
    public int Right;
    public int Bottom;
}

public struct Size
{
    public int Width;
    public int Height;
}

namespace FSCR.Libs
{
    class Checker
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetShellWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowRect(IntPtr hwnd, out RECT rc);

        private IntPtr desktopHandle; //Window handle for the desktop
        private IntPtr shellHandle; //Window handle for the shell

        public bool check()
        {
            //Get the handles for the desktop and shell now.
            desktopHandle = GetDesktopWindow();
            shellHandle = GetShellWindow();

            //get the dimensions of the active window
            IntPtr hWnd = GetForegroundWindow();

            bool runningFullScreen = false;
            RECT appBounds;
            Size size;
            Rectangle screenBounds;

            if (hWnd != null && !hWnd.Equals(IntPtr.Zero))
            {
                //Check we haven't picked up the desktop or the shell
                if (!(hWnd.Equals(desktopHandle) || hWnd.Equals(shellHandle)))
                {
                    GetWindowRect(hWnd, out appBounds);
                    size.Height = appBounds.Bottom + appBounds.Top;
                    size.Width = appBounds.Right + appBounds.Left;
                    //determine if window is fullscreen
                    screenBounds = Screen.FromHandle(hWnd).Bounds;
                    if (size.Height == screenBounds.Height && size.Width == screenBounds.Width)
                    {
                        runningFullScreen = true;
                    }
                }
            }
            return runningFullScreen;
        }
    }
}
