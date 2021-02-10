using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public class AgedBrieItemStrategy : IUpdaterStrategy
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
            AddOnceQualityIfQualitySmallerThan50(item);
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
                AddOnceQualityIfQualitySmallerThan50(item);
            }
        }
        /*-----------------------------------*/
        public void UpdateSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }

    }
}
