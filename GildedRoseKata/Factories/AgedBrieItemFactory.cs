using System;
using System.Collections.Generic;
using GildedRoseKata.Entities;

namespace GildedRoseKata.Factories
{
    public static class AgedBrieItemFactory
    {
        public static Item CreateItem(int sellIn, int quality)
        {
            return new AgedBrieItem(sellIn, quality);
        }
    }
}