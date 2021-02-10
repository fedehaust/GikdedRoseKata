using System;
using System.Collections.Generic;
using GildedRoseKata.Entities;

namespace GildedRoseKata.Factories
{
    public static class SulfurasItemFactory{
        public static Item CreateItem(int sellIn)
        {
            return new SulfurasItem(sellIn);
        }
    }
}