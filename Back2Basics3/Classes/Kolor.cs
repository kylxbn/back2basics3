using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Back2Basics3.Classes
{
    class Kolor
    {
        double R, G, B;

        public Kolor(double r, double g, double b)
        {
            R = r;
            G = g;
            B = b;
        }

        public Kolor(Color c)
        {
            R = c.R;
            G = c.G;
            B = c.B;
        }

        public Color ToColor()
        {
            int r = (int)((R > 255.0) ? 255 : ((R < 0.0) ? 0 : R));
            int g = (int)((G > 255.0) ? 255 : ((G < 0.0) ? 0 : G));
            int b = (int)((B > 255.0) ? 255 : ((B < 0.0) ? 0 : B));
            return Color.FromArgb(r, g, b);
        }

        public int ToArgb()
        {
            return this.ToColor().ToArgb();
        }

        public static Kolor operator +(Kolor l, Kolor r)
        {
            double R = l.R + r.R;
            double G = l.G + r.G;
            double B = l.B + r.B;
            return new Kolor(R, G, B);
        }

        public static Kolor operator -(Kolor l, Kolor r)
        {
            double R = l.R - r.R;
            double G = l.G - r.G;
            double B = l.B - r.B;
            return new Kolor(R, G, B);
        }

        public Kolor Fract(double u, double d)
        {
            double tR = (this.R * u / d);
            double tG = (this.G * u / d);
            double tB = (this.B * u / d);
            return new Kolor(tR, tG, tB);
        }
    }
}
