using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractals
{
    class Circ
    {
        static Graphics Art;
        static Pen MyPen;
        public static void DrawCirc(PictureBox a, Color b, int c)
        {
            
            Art = Graphics.FromHwnd(a.Handle);
            Art.Clear(Color.White);
            MyPen = new Pen(b);
            int g = c;
            CircRecur(390, 280, 279, g);
        }

        public static void CircRecur(double x, double y, double r, int g)
        {
            int n = 6;
            int c = 3;
            double rad = 0;
            double d = 0;
            if (g > 0)
            {
                rad = Math.Round(r/c);
                d = Math.Round(r*(c-1)/c);
                CircRecur(x, y, rad, g-1);
                for (int i = 0; i < n; i++)
                {
                    CircRecur(x-Math.Round(d*Math.Sin(2*Math.PI/n*i)), y+Math.Round(d*Math.Cos(2*Math.PI/n*i)), rad, g-1);
                }
                Art.DrawEllipse(MyPen, (int)(x-r), (int)(y-r), (int)(2*r), (int)(2*r));
            }
        }
    }
}
