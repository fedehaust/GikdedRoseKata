namespace GildedRoseKata.Entities
{
    public class ConjuredItem : ItemWrap
    {
        public const string PrefixedName = "Conjured Mana Cake";
        public ConjuredItem(int sellIn, int quality) : base(PrefixedName, sellIn, quality)
        {
        }
    }
}