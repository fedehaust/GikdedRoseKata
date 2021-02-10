namespace GildedRoseKata.Entities
{
    public class ItemWrap : Item
    {
        public ItemWrap(string name, int sellIn, int quality) {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }
    }
}
