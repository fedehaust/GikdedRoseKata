namespace GildedRoseKata.Entities
{
    public class BackstagePassItem : ItemWrap
    {
        public const string PrefixedName = "Backstage passes to a TAFKAL80ETC concert";
        public BackstagePassItem(int sellIn, int quality) : base(PrefixedName, sellIn, quality)
        {
        }
    }
}