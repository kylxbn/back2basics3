using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Back2Basics3.Classes
{
    class LABBitmap
    {
        public int Width { get; }
        public int Height { get; }

        private LABColor[,] pixels;

        public LABBitmap(Bitmap bmp)
        {
            Width = bmp.Width;
            Height = bmp.Height;

            pixels = new LABColor[Width, Height];

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    pixels[x, y] = new LABColor(bmp.GetPixel(x, y));
        }

        public LABBitmap(int w, int h)
        {
            Width = w;
            Height = h;

            pixels = new LABColor[Width, Height];
        }

        public LABColor GetPixel(int x, int y)
        {
            return pixels[x, y];
        }

        public void SetPixel(int x, int y, LABColor c)
        {
            pixels[x, y] = c;
        }

        public void FillRectangle(LABColor c, int xp, int yp, int w, int h)
        {
            for (int y = yp; (y - yp) < h; y++)
                for (int x = xp; (x - xp) < w; x++)
                    pixels[x, y] = c;
        }

        public LABBitmap Clone()
        {
            LABBitmap bmp = new LABBitmap(this.Width, this.Height);

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    bmp.SetPixel(x, y, this.GetPixel(x, y));

            return bmp;
        }
    }
}
