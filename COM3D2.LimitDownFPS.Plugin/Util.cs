using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace COM3D2.LimitDownFPS.Plugin
{
    internal static class Util
    {
        public static int GetPixel(int value)
        {
            float num = 1f + (Screen.width / 1280f - 1f) * 0.6f;
            return (int)(num * value);
        }

        [DllImport("kernel32.dll")]
        public static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern uint WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
    }
}
