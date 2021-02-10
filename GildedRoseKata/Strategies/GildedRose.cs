using System;
using System.Collections.Generic;
using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public class GildedRose
    {
        public void UpdateQualityAndSellIn(Item item)
        {
            switch (item)
            {
                case AgedBrieItem a:
                    new AgedBrieItemStrategy().UpdateQualityAndSellIn(item);
                    break;
                case BackstagePassItem b:
                    new BackstageItemStrategy().UpdateQualityAndSellIn(item);
                    break;
                case ConjuredItem c:
                    new ConjureItemStrategy().UpdateQualityAndSellIn(item);
                    break;
                case SulfurasItem d:
                    new SulfurasItemStrategy().UpdateQualityAndSellIn(item);
                    break;
                default:
                    new StandardItemStrategy().UpdateQualityAndSellIn(item);
                    break;
            }
        }
    }
}
