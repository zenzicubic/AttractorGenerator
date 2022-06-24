using System;

namespace Renderer
{
    public class Tuple
    {
        public double a, b, c, d;
        public Tuple(double a, double b, double c, double d)
        {
            // data storage class to hold the parameters
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }
    
    public class Renderer {
        public static Bitmap Render(Tuple p, int size, int scale, int points)
        {
            // draw the attractor
            Bitmap b = new(size, size);
            using (Graphics gfx = Graphics.FromImage(b))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(18, 18, 18))) {
                gfx.FillRectangle(brush, 0, 0, size, size);
            }

            double x = 0, y = 0, nx, ny, tx, ty;
            int center = size / 2;
            Color c = Color.FromArgb(255, 127, 17);

            for (int i = 0; i < points; i ++)
            {
                // calculate each step
                nx = Math.Sin(p.a * y) + p.c * Math.Cos(p.a * x);
                ny = Math.Sin(p.b * x) + p.d * Math.Cos(p.b * y);
                x = nx;
                y = ny;

                tx = center + (scale * x);
                ty = center + (scale * y);

                b.SetPixel((int)tx, (int)ty, c);
            }

            return b;
        }
    }
}