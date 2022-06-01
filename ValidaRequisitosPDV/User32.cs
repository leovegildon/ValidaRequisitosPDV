using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Resolucao1024x768
{
    class User32
    {
        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettings(
          string deviceName, int modeNum, ref DEVMODE1 devMode);
        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(
              ref DEVMODE1 devMode, int flags);

        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int CDS_UPDATEREGISTRY = 0x01;
        public const int CDS_TEST = 0x02;
        public const int DISP_CHANGE_SUCCESSFUL = 0;
        public const int DISP_CHANGE_RESTART = 1;
        public const int DISP_CHANGE_FAILED = -1;
    }
}
