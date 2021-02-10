namespace GildedRoseKata.Entities
{
    public class AgedBrieItem : ItemWrap
    {
        public const string PrefixedName = "Aged Brie";
        public AgedBrieItem(int sellIn, int quality) : base(PrefixedName, sellIn, quality)
        {
        }
    }
}