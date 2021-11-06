using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractals
{
    class Dragon
    {
        static Graphics Art;
        static Pen MyPen;
        public static void DrawDragon(PictureBox a, Color b, int c)
        {
            Art = Graphics.FromHwnd(a.Handle);
            Art.Clear(Color.White);
            MyPen = new Pen(b);
            int x1 = 330;
            int y1 = 150;
            int x2 = 330;
            int y2 = 450;
            int g = c;
            DragRecur(x1, y1, x2, y2, g);
        }

        public static void DragRecur(int x1, int y1, int x2, int y2, int g)
        {
            int tempx, tempy;

            if (g > 0)
            {
                tempx = (x1 + x2) / 2 + (y2 - y1) / 2;
                tempy = (y1 + y2) / 2 - (x2 - x1) / 2;
                DragRecur(x2, y2, tempx, tempy, g - 1);
                DragRecur(x1, y1, tempx, tempy, g - 1);
            }
            else
                Art.DrawLine(MyPen, x1, y1, x2, y2);
        }
    }
}
