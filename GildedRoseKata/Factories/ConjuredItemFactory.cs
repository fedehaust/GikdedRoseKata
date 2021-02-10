using System;
using System.Collections.Generic;
using GildedRoseKata.Entities;

namespace GildedRoseKata.Factories
{
    public static class ConjuredItemFactory
    {
        public static Item CreateItem(int sellIn, int quality)
        {
            return new ConjuredItem(sellIn,quality);
        }
    }
}