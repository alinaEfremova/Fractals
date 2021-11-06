using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractals
{
    class Fib
    {
        static Graphics Art;
        static Pen MyPen;
        public static void DrawFib(PictureBox a, Color b, int c)
        {
            
            Art = Graphics.FromHwnd(a.Handle);
            Art.Clear(Color.White);
            MyPen = new Pen(b);
            int g = c;
            float x = 110;
            float y = 480;
            int l = 1;
            FibRecur(x, y, l, g);
        }

        public static void FibRecur(float x, float y, float l, int g)
        {
            string s;
            string s1 = "1";
            string s2 = "0";
            float x0 = 0, y0 = -1;
            float x1 = x;
            float y1 = y;
            float x2, y2, temp;

            for (int i = 0; i < g-2; i++)
            {
                s = s2 + s1;
                s1 = s2;
                s2 = s;
            }

            if (g == 1) s = "1";
            else s = s2;

            char[] schar = new char[100];
            schar = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                x2 = x1 + l * x0;
                y2 = y1 + l * y0;
                Art.DrawLine(MyPen, x1, y1, x2, y2);
                x1 = x2;
                y1 = y2;
                if (schar[i] == '0')
                {
                    if (i % 2 == 0)
                    {
                        temp = x0;
                        x0 = -1 * y0;
                        y0 = temp;
                    }
                    else
                    {
                        temp = x0;
                        x0 = y0;
                        y0 = -1 * temp;
                    }
                }
            }
        }
    }
}
