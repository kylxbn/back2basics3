using System.Collections.Generic;
using System.Drawing;

namespace Back2Basics3.Classes
{
    class NEC_PC : Computer
    {
        public NEC_PC()
        {
            ScreenWidth = 640;
            ScreenHeight = 400;
            TileWidth = 8;
            TileHeight = 8;
            PixelWidth = 1;
            PixelHeight = 1;

            MaxColorPerTile = 8;
            GlobalPaletteSize = 0;

            Palette = new List<Kolor>()
            {
                new Kolor(0,0,0),
                new Kolor(0,0,255),
                new Kolor(0,255,0),
                new Kolor(0,255,255),
                new Kolor(255,0,0),
                new Kolor(255,0,255),
                new Kolor(255,255,0),
                new Kolor(255,255,255)
            };
        }


    }
}
