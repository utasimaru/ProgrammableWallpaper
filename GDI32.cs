﻿using System;
using System.Runtime.InteropServices;

namespace ProgrammableWallpaper
{
    internal class GDI32
    {
        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);
    }
}
