using System;
using System.Collections.Generic;
using GildedRoseKata.Entities;

namespace GildedRoseKata.Factories
{
    public static class StandardItemFactory{
        public static Item CreateItem(string name, int sellIn, int quality)
        {
            return name switch
            {
                AgedBrieItem.PrefixedName => throw new ArgumentException($"You must to use a {nameof(AgedBrieItem)}"),
                BackstagePassItem.PrefixedName => throw new ArgumentException($"You must to use a {nameof(BackstagePassItem)}"),
                ConjuredItem.PrefixedName => throw new ArgumentException($"You must to use a {nameof(ConjuredItem)}"),
                SulfurasItem.PrefixedName => throw new ArgumentException($"You must to use a {nameof(SulfurasItem)}"),
                _ => new ItemWrap(name, sellIn, quality),
            };
        }
    }
}