using GildedRoseKata.Strategies;
using Xunit;
using FluentAssertions;
using GildedRoseKata.Entities;
using GildedRoseKata.Factories;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            Item item = StandardItemFactory.CreateItem("foo", 0, 0);
            new GildedRose().UpdateQualityAndSellIn(item);
            item.Name.Should().BeEquivalentTo("foo");
            item.Quality.Should().Be(0);
            item.SellIn.Should().Be(-1);
        }

        [Fact]
        public void Sulfuras()
        {
            Item item = StandardItemFactory.CreateItem("Sulfuras, Hand of Ragnaros",0,80);
            new GildedRose().UpdateQualityAndSellIn(item);
            item.Name.Should().BeEquivalentTo("Sulfuras, Hand of Ragnaros");
            item.Quality.Should().Be(80);
            item.SellIn.Should().Be(0);
        }

        [Fact]
        public void Conjured()
        {
            Item item = StandardItemFactory.CreateItem("Conjured Mana Cake", 3, 6);
            new GildedRose().UpdateQualityAndSellIn(item);
            item.Name.Should().BeEquivalentTo("Conjured Mana Cake");
            item.Quality.Should().Be(4);
            item.SellIn.Should().Be(2);
        }

        [Fact]
        public void Backstage()
        {
            Item item = StandardItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 5, 48);
            new GildedRose().UpdateQualityAndSellIn(item);
            item.Name.Should().BeEquivalentTo("Backstage passes to a TAFKAL80ETC concert");
            item.Quality.Should().Be(50);
            item.SellIn.Should().Be(4);
        }
    }
}
