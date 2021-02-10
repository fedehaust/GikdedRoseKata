using System;
using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public interface IUpdaterStrategy
    {
        void UpdateQualityAndSellIn(Item item);
    }
}
