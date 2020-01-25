using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Back2Basics3.Classes
{
    class AccuBitmap
    {
        public int Width { get; }
        public int Height { get; }

        private Kolor[,] pixels;

        public AccuBitmap(Bitmap bmp)
        {
            Width = bmp.Width;
            Height = bmp.Height;

            pixels = new Kolor[Width, Height];

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    pixels[x, y] = new Kolor(bmp.GetPixel(x, y));
        }

        public AccuBitmap(int w, int h)
        {
            Width = w;
            Height = h;

            pixels = new Kolor[Width, Height];
        }

        public Kolor GetPixel(int x, int y)
        {
            return pixels[x, y];
        }

        public void SetPixel(int x, int y, Kolor c)
        {
            pixels[x, y] = c;
        }

        public void FillRectangle(Kolor c, int xp, int yp, int w, int h)
        {
            for (int y = yp; (y - yp) < h; y++)
                for (int x = xp; (x - xp) < w; x++)
                    pixels[x, y] = c;
        }

        public Bitmap ToBitmap()
        {
            Bitmap bmp = new Bitmap(Width, Height);

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    bmp.SetPixel(x, y, pixels[x, y].ToColor());

            return bmp;
        }

        public AccuBitmap Clone()
        {
            AccuBitmap bmp = new AccuBitmap(this.Width, this.Height);

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    bmp.SetPixel(x, y, this.GetPixel(x, y));

            return bmp;
        }
    }
}
