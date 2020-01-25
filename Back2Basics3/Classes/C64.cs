using System.Collections.Generic;
using System.Drawing;

namespace Back2Basics3.Classes
{
    class C64 : Computer
    {
        public C64()
        {
            ScreenWidth = 320;
            ScreenHeight = 200;
            TileWidth = 8;
            TileHeight = 8;
            PixelWidth = 2;
            PixelHeight = 1;

            MaxColorPerTile = 3;
            MaxTileNum = 256;
            GlobalPaletteSize = 1;

            BorderWidth = 32;
            BorderHeight = 32;

            Palette = new List<Kolor>()
            {
                new Kolor(255,255,255),
                new Kolor(136,0,0),
                new Kolor(170,255,238),
                new Kolor(204,68,204),
                new Kolor(0,204,85),
                new Kolor(0,0,170),
                new Kolor(238,238,119),
                new Kolor(221,136,85),
                new Kolor(102,68,0),
                new Kolor(255,119,119),
                new Kolor(51,51,51),
                new Kolor(119,119,119),
                new Kolor(170,255,102),
                new Kolor(0,136,255),
                new Kolor(187,187,187)
            };
        }


    }
}
