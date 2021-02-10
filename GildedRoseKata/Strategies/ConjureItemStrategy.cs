using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public class ConjureItemStrategy : IUpdaterStrategy
    {
        public void UpdateQualityAndSellIn(Item item)
        {
            UpdateQualityBefore(item);
            UpdateSellIn(item);
            UpdateQualityAfter(item);
        }

        public void UpdateQualityBefore(Item item)
        {
            RemainsOnceQualityIfQualityBiggerThanZeroAndItemNotSulfuras(item);
        }

        private static void RemainsOnceQualityIfQualityBiggerThanZeroAndItemNotSulfuras(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }
        }

        public void UpdateQualityAfter(Item item)
        {
            if (item.SellIn < 0)
            {
                RemainsQualityIfItemIsBackstageOrNotSulfuras(item);
            }
        }

        private static void RemainsQualityIfItemIsBackstageOrNotSulfuras(Item item)
        {
            if (item.Quality > 0)
            {
                RemainsOnceIfItemNotSulfuras(item);
            }
        }

        private static void RemainsOnceIfItemNotSulfuras(Item item)
        {
            item.Quality = item.Quality - 2;
        }
        /*-----------------------------------*/
        public void UpdateSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}
