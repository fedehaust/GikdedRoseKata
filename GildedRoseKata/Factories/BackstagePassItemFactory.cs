using System;
using System.Collections.Generic;
using GildedRoseKata.Entities;

namespace GildedRoseKata.Factories
{
    public static class BackstagePassItemFactory{
        public static Item CreateItem(int sellIn, int quality)
        {
            return new BackstagePassItem(sellIn,quality);
        }
    }
}