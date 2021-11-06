using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractals
{
    class Barn
    {
        static Graphics Art;
        
        public static void DrawBarn(PictureBox a, Color b, int c)
        {
        Art = Graphics.FromHwnd(a.Handle);
        Art.Clear(Color.White);
        Pen MyPen = new Pen(b);
        int g = c + 5;     
        BarnRecur(new PointF(245, 480), new PointF(306.5385f, 0), 0, MyPen, g);
        }
        public static void BarnRecur(PointF A, PointF B, int Num, Pen P, int g)
        {
            Single Alpha, Beta;
            Single CosA, SinA, CosB, SinB;
            Alpha = 0; Beta = (Single)(Math.PI / 8);
            CosA = (Single)Math.Cos(Alpha);
            SinA = (Single)Math.Sin(Alpha);
            CosB = (Single)Math.Cos(Beta);
            SinB = (Single)Math.Sin(Beta);
            int LMin = (g - 96)*(g - 96);
            PointF C = new PointF();
            PointF E = new PointF();
            PointF F = new PointF();
            PointF G = new PointF();
            PointF D = new PointF();
            Single K1 = 0.18F, K2 = 0.6F;
            if (Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2) > LMin)
            {
                C.X = (int)((B.X - A.X) * CosA - (B.Y - A.Y) * SinA + A.X);
                C.Y = (int)((B.X - A.X) * SinA + (B.Y - A.Y) * CosA + A.Y);
                D.X = (int)(A.X * (1 - K1) + C.X * K1);
                D.Y = (int)(A.Y * (1 - K1) + C.Y * K1);
                E.X = (int)(A.X * (1 - K2) + C.X * K2);
                E.Y = (int)(A.Y * (1 - K2) + C.Y * K2);
                F.X = (int)((E.X - D.X) * CosB - (E.Y - D.Y) * SinB + D.X);
                F.Y = (int)((E.X - D.X) * SinB + (E.Y - D.Y) * CosB + D.Y);
                G.X = (int)((E.X - D.X) * CosB + (E.Y - D.Y) * SinB + D.X);
                G.Y = (int)(-(E.X - D.X) * SinB + (E.Y - D.Y) * CosB + D.Y);

                Art.DrawLine(P, A.X + 100, A.Y + 70, D.X + 100, D.Y + 70);
                BarnRecur(D, C, Num, P, g);
                BarnRecur(D, F, Num + 1, P, g);
                BarnRecur(D, G, Num + 1, P, g);
            }
        }
    }
}
