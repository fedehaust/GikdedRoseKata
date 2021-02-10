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
                "Aged Brie" => new AgedBrieItem(sellIn, quality),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassItem(sellIn, quality),
                "Conjured Mana Cake" => new ConjuredItem(sellIn, quality),
                "Sulfuras, Hand of Ragnaros" => new SulfurasItem(sellIn),
                _ => new ItemWrap(name, sellIn, quality),
            };
        }
    }
}