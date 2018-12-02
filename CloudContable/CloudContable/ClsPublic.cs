using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudContable
{
    class ClsPublic
    {

        public static void Animar(Control ctl)
        {
            AnimateWindow(ctl.Handle, 500, effmap[7] | effmap[0] | effmap[6]);
        }

        public static void Ocultar(Control ctl)
        {
            AnimateWindow(ctl.Handle, 500, effmap[5] | effmap[0]);
        }

        public static void Load(Control ctl)
        {
            AnimateWindow(ctl.Handle, 500, effmap[4] | effmap[7]);
        }

        private static int[] dirmap = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static int[] effmap = { 0x00000001, 0x00000002, 0x00000004, 0x00000008, 0x00000010, 0x00010000, 0x00020000, 0x00040000, 0x00080000 };

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
    }
}
