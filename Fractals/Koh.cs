using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractals
{
    static class Koh
    {
        static Graphics Art;
        static Pen MyPen;
        public static void DrawKoh(PictureBox a, Color b, int c)
        {
            
            Art = Graphics.FromHwnd(a.Handle);
            Art.Clear(Color.White);
            MyPen = new Pen(b);
            PointF p1 = new PointF(150, 150);
            PointF p2 = new PointF(600, 150);
            PointF p3 = new PointF(375, 540);
            int g = c;
            int con = c;
            Art.DrawLine(MyPen, p1, p2);
            Art.DrawLine(MyPen, p2, p3);
            Art.DrawLine(MyPen, p3, p1);
            KohRecur(p1, p2, p3, g, con);
            KohRecur(p2, p3, p1, g, con);
            KohRecur(p3, p1, p2, g, con);
        }

        public static void KohRecur(PointF p1, PointF p2, PointF p3, int g, int con)
        {
            Pen TempPen = new Pen(Color.White);
            if (g > 0)
            {
                PointF p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                PointF p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                PointF px = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                PointF pxy = new PointF((4 * px.X - p3.X) / 3, (4 * px.Y - p3.Y) / 3);
                Art.DrawLine(MyPen, p4, pxy);
                Art.DrawLine(MyPen, p5, pxy);
                Art.DrawLine(MyPen, p4, p5);
                if (con > 4 && g > 4)
                { Art.DrawLine(TempPen, p4, p5); }
                if (con < 5)
                { Art.DrawLine(TempPen, p4, p5); }

                KohRecur(p4, pxy, p5, g-1, con);
                KohRecur(pxy, p5, p4, g-1, con);
                KohRecur(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), g-1, con);
                KohRecur(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), g-1, con);

            }
        }
    }
}
