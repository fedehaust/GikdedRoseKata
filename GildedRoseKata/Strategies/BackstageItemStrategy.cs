using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public class BackstageItemStrategy : IUpdaterStrategy
    {
        public void UpdateQualityAndSellIn(Item item)
        {
            UpdateQualityBefore(item);
            UpdateSellIn(item);
            UpdateQualityAfter(item);
        }

        public void UpdateQualityBefore(Item item)
        {
            AddQualityIfItemIsAgedBrieOrBackstage(item);
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
            AddOnceQualityIfSellInSmallerThan11AndQualitySmallerThan50(item);
            AddOnceQualityIfSellInSmallerThan6AndQualitySmallerThan50(item);
        }

        private static void AddOnceQualityIfSellInSmallerThan11AndQualitySmallerThan50(Item item)
        {
            if (item.SellIn < 11)
            {
                AddOnceQualityIfQualitySmallerThan50(item);
            }
        }

        private static void AddOnceQualityIfSellInSmallerThan6AndQualitySmallerThan50(Item item)
        {
            if (item.SellIn < 6)
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

        public void UpdateQualityAfter(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }

        /*-----------------------------------*/
        public void UpdateSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}
