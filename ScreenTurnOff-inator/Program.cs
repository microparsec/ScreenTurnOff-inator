using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTurnOff_inator
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        static void Main(string[] args)
        {
            SendMessage(-1, 0x0112, 0xF170, 2);
        }
    }
}
