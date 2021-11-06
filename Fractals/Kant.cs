using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractals
{
    class Kant
    {
        static Graphics Art;
        public static void DrawKant(PictureBox a, Color b, int c)
        {
            
            Art = Graphics.FromHwnd(a.Handle);
            Art.Clear(Color.White);
            Color col = b;
            int g = c;
            KantRecur(10, 130, 760, col, g);            
        }

        public static void KantRecur(int x, int y, int l, Color col, int g)
        {
            if (g > 0)
            {
                Art.FillRectangle(new SolidBrush(col), x, y, l, 30);
                y = y + 45;
                KantRecur(x + l * 2 / 3, y, l / 3, col, g - 1);
                KantRecur(x, y, l / 3, col, g - 1);
            }
        }
    }
}
