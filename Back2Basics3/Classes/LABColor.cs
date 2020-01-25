using System;
using System.Drawing;

namespace Back2Basics3.Classes
{
    class LABColor
    {
        private double L { get; set; }
        private double A { get; set; }
        private double B { get; set; }

        public LABColor(double l, double a, double b)
        {
            L = l;
            A = a;
            B = b;
        }

        public LABColor(Color col)
        {
            LABColor temp = FromColor(col);
            L = temp.L;
            A = temp.A;
            B = temp.B;
        }

        public LABColor(Kolor col)
        {
            LABColor temp = FromColor(col.ToColor());
            L = temp.L;
            A = temp.A;
            B = temp.B;
        }

        public static double Distance(LABColor a, LABColor b)
        {
            return Math.Sqrt(Math.Pow((a.L - b.L), 2f) + Math.Pow((a.A - b.A), 2f) + Math.Pow((a.B - b.B), 2f));
        }

        public static LABColor FromColor(Color c)
        {
            double D65x = 0.9505f;
            double D65y = 1.0f;
            double D65z = 1.0890f;

            double RLinear = c.R / 255d;
            double GLinear = c.G / 255d;
            double BLinear = c.B / 255d;

            double R = (RLinear > 0.04045f) ? Math.Pow((RLinear + 0.055f) / (1f + 0.055f), 2.2f) : (RLinear / 12.92f);
            double G = (GLinear > 0.04045f) ? Math.Pow((GLinear + 0.055f) / (1f + 0.055f), 2.2f) : (GLinear / 12.92f);
            double B = (BLinear > 0.04045f) ? Math.Pow((BLinear + 0.055f) / (1f + 0.055f), 2.2f) : (BLinear / 12.92f);

            double x = (R * 0.4124f + G * 0.3576f + B * 0.1805f);
            double y = (R * 0.2126f + G * 0.7152f + B * 0.0722f);
            double z = (R * 0.0193f + G * 0.1192f + B * 0.9505f);

            x = (x > 0.9505f) ? 0.9505f : ((x < 0f) ? 0f : x);
            y = (y > 1f) ? 1f : ((y < 0f) ? 0f : y);
            z = (z > 1.089f) ? 1.089f : ((z < 0f) ? 0f : z);

            LABColor lab = new LABColor(0f, 0f, 0f);

            double fx = x / D65x;
            double fy = y / D65y;
            double fz = z / D65z;

            fx = ((fx > 0.008856f) ? Math.Pow(fx, (1f / 3f)) : (7.787f * fx + 16f / 116f));
            fy = ((fy > 0.008856f) ? Math.Pow(fy, (1f / 3f)) : (7.787f * fy + 16f / 116f));
            fz = ((fz > 0.008856f) ? Math.Pow(fz, (1f / 3f)) : (7.787f * fz + 16f / 116f));

            lab.L = 116f * fy - 16f;
            lab.A = 500f * (fx - fy);
            lab.B = 200f * (fy - fz);

            return lab;
        }

        public static LABColor operator +(LABColor a, LABColor b)
        {
            return new LABColor(a.L + b.L, a.A + b.A, a.B + b.B);
        }

        public static LABColor operator -(LABColor a, LABColor b)
        {
            return new LABColor(a.L - b.L, a.A - b.A, a.B - b.B);
        }

        public static LABColor operator /(LABColor a, double b)
        {
            return new LABColor(a.L / b, a.A / b, a.B / b);
        }
    }
}
