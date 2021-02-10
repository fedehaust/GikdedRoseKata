using System;
using System.Collections.Generic;
using GildedRoseKata.Entities;
using GildedRoseKata.Factories;
using GildedRoseKata.Strategies;
using static System.Console;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Item> Items = new List<Item>{
                StandardItemFactory.CreateItem("+5 Dexterity Vest", 10, 20),
                StandardItemFactory.CreateItem("Aged Brie", 2, 0),
                StandardItemFactory.CreateItem("Elixir of the Mongoose", 5, 7),
                StandardItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", 0,80),
                StandardItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", -1,80),
                StandardItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                StandardItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                StandardItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                StandardItemFactory.CreateItem("Conjured Mana Cake", 3, 6)
            };

            for (var i = 0; i < 31; i++)
            {
                WriteLine("-------- day " + i + " --------");
                WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    WriteLine(Items[j]);
                    new GildedRose().UpdateQualityAndSellIn(Items[j]);
                }
                WriteLine("");
            }
        }
    }
}
