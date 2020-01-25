using System.Collections.Generic;
using System.Drawing;

namespace Back2Basics3.Classes
{
    class NES_MMC5 : Computer
    {
        public NES_MMC5()
        {
            ScreenWidth = 256;
            ScreenHeight = 224;
            TileWidth = 8;
            TileHeight = 8;
            PixelWidth = 1;
            PixelHeight = 1;

            MaxColorPerTile = 4;
            GlobalPaletteSize = 0;

            MaxTileNum = 256;

            Palette = new List<Kolor>()
            {
                new Kolor(109,109,109),
                new Kolor(182,182,182),
                new Kolor(255,255,255),
                new Kolor(0,36,146),
                new Kolor(0,109,219),
                new Kolor(109,182,255),
                new Kolor(182,219,255),
                new Kolor(0,0,219),
                new Kolor(0,73,255),
                new Kolor(146,146,255),
                new Kolor(219,182,255),
                new Kolor(109,73,219),
                new Kolor(146,0,255),
                new Kolor(219,109,255),
                new Kolor(255,182,255),
                new Kolor(146,0,109),
                new Kolor(182,0,255),
                new Kolor(255,0,255),
                new Kolor(255,146,255),
                new Kolor(182,0,109),
                new Kolor(255,0,146),
                new Kolor(255,109,255),
                new Kolor(255,182,182),
                new Kolor(182,36,0),
                new Kolor(255,0,0),
                new Kolor(255,146,0),
                new Kolor(255,219,146),
                new Kolor(146,73,0),
                new Kolor(219,109,0),
                new Kolor(255,182,0),
                new Kolor(255,255,73),
                new Kolor(109,73,0),
                new Kolor(146,109,0),
                new Kolor(219,219,0),
                new Kolor(255,255,109),
                new Kolor(36,73,0),
                new Kolor(36,146,0),
                new Kolor(109,219,0),
                new Kolor(182,255,73),
                new Kolor(0,109,36),
                new Kolor(0,146,0),
                new Kolor(0,255,0),
                new Kolor(146,255,109),
                new Kolor(0,182,109),
                new Kolor(73,255,219),
                new Kolor(0,73,73),
                new Kolor(0,146,146),
                new Kolor(0,255,255),
                new Kolor(146,219,255),
                new Kolor(0,0,0),
                new Kolor(36,36,36),
                new Kolor(73,73,73),
                new Kolor(146,146,146)
            };
        }


    }
}
