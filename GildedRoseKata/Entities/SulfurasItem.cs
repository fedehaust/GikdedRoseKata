namespace GildedRoseKata.Entities
{
    public class SulfurasItem : ItemWrap
    {
        public const string PrefixedName = "Sulfuras, Hand of Ragnaros";
        public SulfurasItem(int sellIn):base(PrefixedName, sellIn,80)
        {
        }
    }
}