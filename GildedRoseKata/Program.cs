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
                AgedBrieItemFactory.CreateItem(2, 0),
                StandardItemFactory.CreateItem("Elixir of the Mongoose", 5, 7),
                SulfurasItemFactory.CreateItem(0),
                SulfurasItemFactory.CreateItem(-1),
                BackstagePassItemFactory.CreateItem(15, 20),
                BackstagePassItemFactory.CreateItem(10, 49),
                BackstagePassItemFactory.CreateItem(5, 49),
                ConjuredItemFactory.CreateItem(3, 6)
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
