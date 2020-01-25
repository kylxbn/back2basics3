using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;

namespace Back2Basics3.Classes
{
    abstract class Computer
    {
        protected List<Kolor> Palette = null;
        protected List<Kolor> GlobalPalette = null;

        protected int MaxColorPerTile = 0;
        protected int GlobalPaletteSize = 0;
        protected int ScreenWidth = 0, ScreenHeight = 0;
        protected int PixelWidth = 0, PixelHeight = 0;
        protected int TileWidth = 0, TileHeight = 0;
        protected int MaxTileNum = 0;

        protected int BorderWidth = 0;
        protected int BorderHeight = 0;

        int[] GetClosestColorIndex(Kolor c, List<Kolor> pal)
        {
            LABColor a = new LABColor(c);
            LABColor b;

            // index of the corresponding scores
            int[] score_index = new int[pal.Count];
            for (int i = 0; i < pal.Count; i++)
                score_index[i] = i;

            // index of the scores
            double[] scores = new double[pal.Count];
            for (int i = 0; i < pal.Count; i++)
            {
                b = new LABColor(pal[i]);
                scores[i] = LABColor.Distance(a, b);
            }

            // sort the scores, while making the indices follow
            SortFollow(ref scores, ref score_index);

            return score_index;
        }

        static void SortFollow(ref double[] s, ref int[] c)
        {
            int iv;
            double dv;

            for (int pass = 0; pass<s.Length-1; pass++)
                for (int j = 0; j<s.Length-1; j++)
                    if (s[j]>s[j+1])
                    {
                        dv = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = dv;
                        iv = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = iv;
                    }
        }

        void SortFollow(ref int[] s, ref int[] c)
        {
            int iv;

            for (int pass = 0; pass < s.Length - 1; pass++)
                for (int j = 0; j < s.Length - 1; j++)
                    if (s[j] > s[j + 1])
                    {
                        iv = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = iv;
                        iv = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = iv;
                    }
        }

        void SortFollowRev(ref int[] s, ref int[] c)
        {
            int iv;

            for (int pass = 0; pass < s.Length - 1; pass++)
                for (int j = 0; j < s.Length - 1; j++)
                    if (s[j] < s[j + 1])
                    {
                        iv = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = iv;
                        iv = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = iv;
                    }
        }

        public List<Kolor> GetPalette(AccuBitmap bmp, List<Kolor> pal, int count, Kolor except, int xs = 0, int ys = 0, int width = 0, int height = 0)
        {
            int[] score = new int[pal.Count];
            for (int i = 0; i < score.Length; i++)
                score[i] = 0;

            if (width == 0) width = bmp.Width;
            if (height == 0) height = bmp.Height;

            int[] closest;

            for (int y = ys; y < (ys + height); y++)
                for (int x = xs; x < (xs + width); x++)
                {
                    closest = GetClosestColorIndex(bmp.GetPixel(x, y), pal);
                    for (int i = 0; i < closest.Length; i++)
                    {
                        score[closest[i]] += closest.Length - i;
                    }
                }

            int[] score_index = new int[score.Length];
            for (int i = 0; i < score_index.Length; i++)
                score_index[i] = i;

            SortFollowRev(ref score, ref score_index);

            List<Kolor> ret = new List<Kolor>();

            for (int i = 0; i < count; i++)
            {
                if (pal[score_index[i]].ToArgb() != except.ToArgb())
                    ret.Add(pal[score_index[i]]);
            }
            
            return ret;
        }

        public List<Kolor> GetPalette(AccuBitmap bmp, List<Kolor> pal, int count, int xs = 0, int ys = 0, int width = 0, int height = 0)
        {
            if (count == Palette.Count)
                return Palette;

            int[] score = new int[pal.Count];
            for (int i = 0; i < score.Length; i++)
                score[i] = 0;

            if (width == 0) width = bmp.Width;
            if (height == 0) height = bmp.Height;

            int[] closest;

            for (int y = ys; y < (ys+height); y++)
                for (int x = xs; x < (xs+width); x++)
                {
                    closest = GetClosestColorIndex(bmp.GetPixel(x, y), pal);
                    for (int i = 0; i < closest.Length; i++)
                    {
                        score[closest[i]] += closest.Length - i;
                    }
                }

            int[] score_index = new int[score.Length];
            for (int i = 0; i < score_index.Length; i++)
                score_index[i] = i;

            SortFollowRev(ref score, ref score_index);

            List<Kolor> ret = new List<Kolor>();

            for (int i = 0; i < count; i++)
            {
                ret.Add(pal[score_index[i]]);
            }

            return ret;
        }

        public Bitmap Resize(Bitmap bmp)
        {
            double FullWidth = (double)ScreenWidth / bmp.Width;
            double FullHeight = (double)ScreenHeight / bmp.Height;
            double FullWidthPAR = (double)ScreenWidth / bmp.Width / PixelWidth;
            double FullHeightPAR = (double)ScreenHeight / bmp.Height / PixelHeight;
            double Ratio = FullWidth < FullHeight ? FullWidth : FullHeight;
            double RatioPAR = FullWidthPAR < FullHeightPAR ? FullWidthPAR : FullHeightPAR;

            int RealWidth = (int)(bmp.Width * Ratio);
            int RealHeight = (int)(bmp.Height * Ratio);
            int RealWidthPAR = (int)(bmp.Width * RatioPAR);
            int RealHeightPAR = (int)(bmp.Height * RatioPAR);
            int LeftBorder = (ScreenWidth - RealWidth) / 2;
            int UpperBorder = (ScreenHeight - RealHeight) / 2;

            Bitmap resized = new Bitmap(RealWidthPAR, RealHeightPAR);
            Graphics resized_g = Graphics.FromImage(resized);
            resized_g.DrawImage(bmp, 0, 0, RealWidthPAR, RealHeightPAR);

            Kolor fillColor;
            
                GetGlobalPalette(new AccuBitmap(resized));
                fillColor = GlobalPalette[0];

            SolidBrush brush = new SolidBrush(fillColor.ToColor());

            Bitmap res = new Bitmap(ScreenWidth, ScreenHeight);
            Graphics resg = Graphics.FromImage(res);
            resg.FillRectangle(brush,0, 0, ScreenWidth, ScreenHeight);
            resg.DrawImage(resized, LeftBorder, UpperBorder, RealWidth, RealHeight);

            brush.Dispose();
            resized.Dispose();
            return res;
        }

        void GetGlobalPalette(AccuBitmap bmp)
        {
            if (GlobalPaletteSize > 0)
                GlobalPalette = GetPalette(bmp, Palette, GlobalPaletteSize);
            else
                GlobalPalette = GetPalette(bmp, Palette, 1);
        }

        public AccuBitmap ReduceColor(AccuBitmap bmp, BackgroundWorker bgw)
        {
            if (GlobalPaletteSize > 0)
                if (GlobalPalette == null)
                    GetGlobalPalette(bmp);

            int tilePaletteWidth = ScreenWidth / TileWidth;
            int tilePaletteHeight = ScreenHeight / TileHeight;
            List<Kolor>[,] tilepalette = new List<Kolor>[tilePaletteWidth, tilePaletteHeight];

            for (int y = 0; y < tilePaletteHeight; y++)
            {
                for (int x = 0; x < tilePaletteWidth; x++)
                {
                    if (GlobalPaletteSize > 0)
                        tilepalette[x, y] = GetPalette(bmp, Palette, MaxColorPerTile, GlobalPalette[0], x * TileWidth, y * TileHeight, TileWidth, TileHeight);
                    else
                        tilepalette[x, y] = GetPalette(bmp, Palette, MaxColorPerTile, x * TileWidth, y * TileHeight, TileWidth, TileHeight);

                }
                bgw.ReportProgress((int)((double)y / tilePaletteHeight * 50));
            }

            if (GlobalPaletteSize>0)
            {
                for (int y = 0; y < tilePaletteHeight; y++)
                    for (int x = 0; x < tilePaletteWidth; x++)
                    {
                        tilepalette[x, y].AddRange(GlobalPalette);
                    }
            }

            AccuBitmap res = bmp.Clone();
            Kolor col;

            for (int y = 0; y < ScreenHeight; y+= PixelHeight)
            {
                for (int x = 0; x < ScreenWidth; x+= PixelWidth)
                {
                    Kolor orig = res.GetPixel(x, y);
                    Kolor changed = tilepalette[x / TileWidth, y / TileHeight][GetClosestColorIndex(res.GetPixel(x, y), tilepalette[x / TileWidth, y / TileHeight])[0]];
                    Kolor quantError = orig - changed;
                    col = changed;
                    res.FillRectangle(col, x, y, PixelWidth, PixelHeight);

                    // SECOND
                    if (x + PixelWidth < ScreenWidth)
                    {
                        col = res.GetPixel(x + PixelWidth, y) + quantError.Fract(7, 16);
                        res.FillRectangle(col, x + PixelWidth, y, PixelWidth, PixelHeight);
                    }
                    // THIRD
                    if ((x - PixelWidth > 0) && (y + PixelHeight < ScreenHeight))
                    {
                        col = res.GetPixel(x - PixelWidth, y + PixelHeight) + quantError.Fract(3, 16);
                        res.FillRectangle(col, x - PixelWidth, y + PixelHeight, PixelWidth, PixelHeight);
                    }
                    // FOURTH
                    if (y + PixelHeight < ScreenHeight)
                    {
                        col = res.GetPixel(x, y + PixelHeight) + quantError.Fract(5, 16);
                        bmp.FillRectangle(col, x, y + PixelHeight, PixelWidth, PixelHeight);
                    }
                    // FIFTH
                    if ((x + PixelWidth < ScreenWidth) && (y + PixelHeight < ScreenHeight))
                    {
                        col = res.GetPixel(x + PixelWidth, y + PixelHeight) + quantError.Fract(1, 16);
                        bmp.FillRectangle(col, x + PixelWidth, y + PixelHeight, PixelWidth, PixelHeight);
                    }

                    
                }
                bgw.ReportProgress((int)((double)y / ScreenHeight * 50) + 50);
            }
            bgw.ReportProgress(100);

            return res;
        }

        public Bitmap ReduceTileset(Bitmap bmp, BackgroundWorker bgw)
        {
            // first, get a list of tiles.
            int TileWidthNum = ScreenWidth / TileWidth; // number of horizontal tiles in screen
            int TileHeightNum = ScreenHeight / TileHeight; // ditto, but vertical
            int ScreenTiles = TileWidthNum * TileHeightNum; // number of all tiles on screen

            // if current tile count is not limited or is equal to the maximum tile count...
            if ((MaxTileNum == 0) || (ScreenTiles <= MaxTileNum))
                return bmp;

            // but the world doesn't go like that always ;)
            // So we continue our job.

            Bitmap[] tiles = new Bitmap[ScreenTiles]; // contains ALL the original tiles
            Bitmap temp;
            Graphics temp_g;
            int[,] OriginalTiles = new int[TileWidthNum, TileHeightNum]; // points to the original tiles

            int counter = 0;
            for (int y = 0; y < TileHeightNum; y++)
                for (int x = 0; x < TileWidthNum; x++)
                {
                    temp = new Bitmap(TileWidth, TileHeight);
                    temp_g = Graphics.FromImage(temp);
                    temp_g.DrawImageUnscaled(bmp, -(x * TileWidth), -(y * TileHeight));
                    tiles[counter] = temp;
                    OriginalTiles[x, y] = counter;
                    counter++;
                }

            // let's make an array that will contain the difference to minimize the amount
            // of calculations necessary and speed up the routine
            double[,] DifferenceResults = new double[ScreenTiles, ScreenTiles];
            for (int i = 0; i < ScreenTiles; i++)
            {
                for (int j = 0; j < ScreenTiles; j++)
                {
                    DifferenceResults[i, j] = -1;
                }
                bgw.ReportProgress((int)((double)i / ScreenTiles * 100));
            }
            for (int i = 0; i < ScreenTiles; i++)
            {
                for (int j = 0; j < ScreenTiles; j++)
                {
                    if (DifferenceResults[j, i] >= 0)
                        DifferenceResults[i, j] = DifferenceResults[j, i];
                    else
                        DifferenceResults[i, j] = CompareTiles(tiles[i], tiles[j]);
                }
                bgw.ReportProgress((int)((double)i / ScreenTiles * 100));
            }

            // let's make a List that contains (not yet) excempted tiles
            List<int> UnexcemptedTiles = new List<int>();
            for (int i = 0; i < ScreenTiles; i++)
                UnexcemptedTiles.Add(i);

            do
            {
                // then, let's get the difference of each tile against each tile
                double lowestDifference = DifferenceResults[UnexcemptedTiles[0], UnexcemptedTiles[1]]; // let's not compare the tile to itself
                int leftIndex = UnexcemptedTiles[0];
                int rightIndex = UnexcemptedTiles[1];
                double CompareResult;
                for (int i = 0; i < UnexcemptedTiles.Count; i++)
                    for (int j = 2; j < UnexcemptedTiles.Count; j++)
                    {
                        if (i != j)
                        {
                            CompareResult = DifferenceResults[UnexcemptedTiles[i], UnexcemptedTiles[j]];
                            if (CompareResult < lowestDifference)
                            {
                                lowestDifference = CompareResult;
                                leftIndex = UnexcemptedTiles[i];
                                rightIndex = UnexcemptedTiles[j];
                            }
                        }
                    }

                // now we have the most similar tiles' indices. Let's remove them from the list and
                // update the screen
                UnexcemptedTiles.Remove(rightIndex); // we remove the "rightIndex" which is a duplicate (not really) of "leftIndex"
                for (int y = 0; y < TileHeightNum; y++)
                    for (int x = 0; x < TileWidthNum; x++)
                    {
                        if (OriginalTiles[x, y] == rightIndex)
                            OriginalTiles[x, y] = leftIndex;
                    }

                bgw.ReportProgress(100 - (int)((double)(UnexcemptedTiles.Count - MaxTileNum) / (ScreenTiles - MaxTileNum)*100));
            }
            while (UnexcemptedTiles.Count > MaxTileNum);

            // let's redraw the screen using the new tiles
            Bitmap res = new Bitmap(ScreenWidth, ScreenHeight);
            Graphics res_g = Graphics.FromImage(res);
            for (int y = 0; y < TileHeightNum; y++)
                for (int x = 0; x < TileWidthNum; x++)
                {
                    res_g.DrawImage(tiles[OriginalTiles[x, y]], x * TileWidth, y*TileHeight);
                }

            foreach (Bitmap b in tiles)
                b.Dispose();

            return res;
        }

        public Bitmap ReduceTilesetSimple(Bitmap bmp, BackgroundWorker bgw)
        {
            // first, get a list of tiles.
            int TileWidthNum = ScreenWidth / TileWidth; // number of horizontal tiles in screen
            int TileHeightNum = ScreenHeight / TileHeight; // ditto, but vertical
            int ScreenTiles = TileWidthNum * TileHeightNum; // number of all tiles on screen

            // if current tile count is not limited or is equal to the maximum tile count...
            if ((MaxTileNum == 0) || (ScreenTiles <= MaxTileNum))
                return bmp;

            // but the world doesn't go like that always ;)
            // So we continue our job.

            Bitmap[] tiles = new Bitmap[ScreenTiles]; // contains ALL the original tiles
            Bitmap temp;
            Graphics temp_g;
            int[,] OriginalTiles = new int[TileWidthNum, TileHeightNum]; // points to the original tiles

            int counter = 0;
            for (int y = 0; y < TileHeightNum; y++)
                for (int x = 0; x < TileWidthNum; x++)
                {
                    temp = new Bitmap(TileWidth, TileHeight);
                    temp_g = Graphics.FromImage(temp);
                    temp_g.DrawImageUnscaled(bmp, -(x * TileWidth), -(y * TileHeight));
                    tiles[counter] = temp;
                    OriginalTiles[x, y] = counter;
                    counter++;
                }

            // let's make an array that will contain the difference to minimize the amount
            // of calculations necessary and speed up the routine
            double[,] DifferenceResults = new double[ScreenTiles, ScreenTiles];
            for (int i = 0; i < ScreenTiles; i++)
            {
                for (int j = 0; j < ScreenTiles; j++)
                {
                    DifferenceResults[i, j] = -1;
                }
                bgw.ReportProgress((int)((double)i / ScreenTiles * 100));
            }
            for (int i = 0; i < ScreenTiles; i++)
            {
                for (int j = 0; j < ScreenTiles; j++)
                {
                    if (DifferenceResults[j, i] >= 0)
                        DifferenceResults[i, j] = DifferenceResults[j, i];
                    else
                        DifferenceResults[i, j] = CompareTilesSimple(tiles[i], tiles[j]);
                }
                bgw.ReportProgress((int)((double)i / ScreenTiles * 100));
            }

            // let's make a List that contains (not yet) excempted tiles
            List<int> UnexcemptedTiles = new List<int>();
            for (int i = 0; i < ScreenTiles; i++)
                UnexcemptedTiles.Add(i);

            do
            {
                // then, let's get the difference of each tile against each tile
                double lowestDifference = DifferenceResults[UnexcemptedTiles[0], UnexcemptedTiles[1]]; // let's not compare the tile to itself
                int leftIndex = UnexcemptedTiles[0];
                int rightIndex = UnexcemptedTiles[1];
                double CompareResult;
                for (int i = 0; i < UnexcemptedTiles.Count; i++)
                    for (int j = 2; j < UnexcemptedTiles.Count; j++)
                    {
                        if (i != j)
                        {
                            CompareResult = DifferenceResults[UnexcemptedTiles[i], UnexcemptedTiles[j]];
                            if (CompareResult < lowestDifference)
                            {
                                lowestDifference = CompareResult;
                                leftIndex = UnexcemptedTiles[i];
                                rightIndex = UnexcemptedTiles[j];
                            }
                        }
                    }

                // now we have the most similar tiles' indices. Let's remove them from the list and
                // update the screen
                UnexcemptedTiles.Remove(rightIndex); // we remove the "rightIndex" which is a duplicate (not really) of "leftIndex"
                for (int y = 0; y < TileHeightNum; y++)
                    for (int x = 0; x < TileWidthNum; x++)
                    {
                        if (OriginalTiles[x, y] == rightIndex)
                            OriginalTiles[x, y] = leftIndex;
                    }

                bgw.ReportProgress(100 - (int)((double)(UnexcemptedTiles.Count - MaxTileNum) / (ScreenTiles - MaxTileNum) * 100));
            }
            while (UnexcemptedTiles.Count > MaxTileNum);

            // let's redraw the screen using the new tiles
            Bitmap res = new Bitmap(ScreenWidth, ScreenHeight);
            Graphics res_g = Graphics.FromImage(res);
            for (int y = 0; y < TileHeightNum; y++)
                for (int x = 0; x < TileWidthNum; x++)
                {
                    res_g.DrawImage(tiles[OriginalTiles[x, y]], x * TileWidth, y * TileHeight);
                }

            foreach (Bitmap b in tiles)
                b.Dispose();

            return res;
        }

        private double CompareTilesComplex(Bitmap a, Bitmap b)
        {
            double res = 0;

            a = Blur(a);

            return res;
        }

        private Bitmap Blur(Bitmap i)
        {
            AccuBitmap res = new AccuBitmap(i);

            int w = i.Width;
            int h = i.Height;
            int wm1 = w - 1;
            int hm1 = h - 1;

            int tx, ty;

            Kolor[] c = new Kolor[9];

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    tx = x - 1; ty = y - 1;
                    c[0] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx++;
                    c[1] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx++;
                    c[2] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx = x - 1; ty++;
                    c[3] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx++;
                    c[4] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx++;
                    c[5] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx = x - 1; ty++;
                    c[6] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx++;
                    c[7] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    tx++;
                    c[8] = new Kolor(i.GetPixel(tx < 0 ? wm1 : (tx > wm1 ? wm1 : tx), ty < 0 ? wm1 : (ty > wm1 ? wm1 : ty)));
                    res.SetPixel(x, y, (c[0] + c[1] + c[2] + c[3] + c[4] + c[5] + c[6] + c[7] + c[8]).Fract(1,9));
                }
            }

            return res.ToBitmap();
        }

        private double CompareTiles(Bitmap a, Bitmap b)
        {
            int w = a.Width < b.Width ? a.Width : b.Width;
            int h = a.Height < b.Height ? a.Height : b.Height;

            double res = 0;
            LABBitmap tilea = new LABBitmap(a);
            LABBitmap tileb = new LABBitmap(b);

            double def = 0, left = 0, up = 0;

            for (int y = 0; y < h; y+=PixelHeight)
                for (int x = 0; x < w; x+=PixelWidth)
                {
                    def += LABColor.Distance(tilea.GetPixel(x, y), tileb.GetPixel(x, y));
                    left += LABColor.Distance(tilea.GetPixel(x, y), tileb.GetPixel((x + PixelWidth) % TileWidth, y));
                    up += LABColor.Distance(tilea.GetPixel(x, y), tileb.GetPixel(x, (y + PixelHeight) % TileHeight));
                }

            res = def;
            if (res > left) res = left;
            if (res > up) res = up;

            return res;
        }

        private double CompareTilesSimple(Bitmap a, Bitmap b)
        {
            int w = a.Width < b.Width ? a.Width : b.Width;
            int h = a.Height < b.Height ? a.Height : b.Height;

            Bitmap c = Blur(new Bitmap(a));
            Bitmap d = Blur(new Bitmap(b));

            double def = 0;

            for (int y = 0; y < h; y+=PixelHeight)
                for (int x = 0; x < w; x+=PixelWidth)
                {
                    def += LABColor.Distance(new LABColor(c.GetPixel(x, y)), new LABColor(d.GetPixel(x, y)));
                }
            return def;
        }

        public Bitmap Border(Bitmap a)
        {
            Bitmap res = new Bitmap(BorderWidth * 2 + ScreenWidth, BorderHeight * 2 + ScreenHeight);
            Graphics res_g = Graphics.FromImage(res);
            res_g.FillRectangle(new SolidBrush(GlobalPalette[0].ToColor()), 0, 0, res.Width, res.Height);
            res_g.DrawImage(a, BorderWidth, BorderHeight);
            return res;
        }
    }
}
