using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractals
{
    class Levi
    {
        static Graphics Art;
        static Pen MyPen;
        public static void DrawLevi(PictureBox a, Color b, int c)
        {
            Art = Graphics.FromHwnd(a.Handle);
            Art.Clear(Color.White);
            MyPen = new Pen(b);
            int g = c;
            LeviRecur(MyPen, 330, 510, 190, 190, g);
            LeviRecur(MyPen, 510, 510, 190, 370, g);
            LeviRecur(MyPen, 510, 330, 370, 370, g);
            LeviRecur(MyPen, 330, 330, 370, 190, g);
        }

        public static void LeviRecur(Pen p, int x1, int x2, int y1, int y2, int g)
        {
            if (g == 0)
            {
                Art.DrawLine(p, x1, y1, x2, y2);
            }
            else
            {
                int x3 = (x1 + x2) / 2 + (y2 - y1) / 2;
                int y3 = (y1 + y2) / 2 - (x2 - x1) / 2;
                LeviRecur(p, x1, x3, y1, y3, g - 1);
                LeviRecur(p, x3, x2, y3, y2, g - 1);
            }
        }
    }
}
