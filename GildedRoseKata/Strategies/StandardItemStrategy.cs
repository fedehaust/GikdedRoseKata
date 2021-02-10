using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public class StandardItemStrategy : IUpdaterStrategy
    {
        public void UpdateQualityAndSellIn(Item item)
        {
            UpdateQualityBefore(item);
            UpdateSellIn(item);
            UpdateQualityAfter(item);
        }

        public void UpdateQualityBefore(Item item)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                RemainsOnceQualityIfQualityBiggerThanZeroAndItemNotSulfuras(item);
            }
            else
            {
                AddQualityIfItemIsAgedBrieOrBackstage(item);
            }
        }

        private static void AddQualityIfItemIsAgedBrieOrBackstage(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                AddQualityIfItemIsBackstage(item);
            }
        }

        private static void AddQualityIfItemIsBackstage(Item item)
        {
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                AddOnceQualityIfSellInSmallerThan11AndQualitySmallerThan50(item);

                AddOnceQualityIfSellInSmallerThan6AndQualitySmallerThan50(item);
            }
        }

        private static void AddOnceQualityIfSellInSmallerThan6AndQualitySmallerThan50(Item item)
        {
            if (item.SellIn < 6)
            {
                AddOnceQualityIfQualitySmallerThan50(item);
            }
        }

        private static void AddOnceQualityIfSellInSmallerThan11AndQualitySmallerThan50(Item item)
        {
            if (item.SellIn < 11)
            {
                AddOnceQualityIfQualitySmallerThan50(item);

            }
        }

        private static void AddOnceQualityIfQualitySmallerThan50(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
        private static void RemainsOnceQualityIfQualityBiggerThanZeroAndItemNotSulfuras(Item item)
        {
            if (item.Quality > 0)
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }
        /*---------------------------------------------------------------------------------------------------------*/
        public void UpdateQualityAfter(Item item)
        {
            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    RemainsQualityIfItemIsBackstageOrNotSulfuras(item);
                }
                else
                {
                    AddOnceQualityIfQualitySmallerThan50(item);
                }

            }
        }

        private static void RemainsQualityIfItemIsBackstageOrNotSulfuras(Item item)
        {
            if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality > 0)
                {
                    RemainsOnceIfItemNotSulfuras(item);
                }
            }
            else
            {
                item.Quality = item.Quality - item.Quality;
            }
        }

        private static void RemainsOnceIfItemNotSulfuras(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality = item.Quality - 1;
            }
        }
        /*---------------------------------------------------------------------------------------------------------*/
        public void UpdateSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }
        }
    }
}
