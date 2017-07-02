using System;
using System.Windows.Forms;

namespace VKTIM
{
    public partial class CursorX : System.Windows.Forms.UserControl
    {
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern IntPtr LoadCursorFromFile(String str);

        public static Cursor Create(String filename)
        {
            IntPtr hCursor = LoadCursorFromFile(filename);

            if (!IntPtr.Zero.Equals(hCursor))
            {
                return new Cursor(hCursor);
            }
            else
            {
                return System.Windows.Forms.Cursors.Default;
            }
        }
    }
}
