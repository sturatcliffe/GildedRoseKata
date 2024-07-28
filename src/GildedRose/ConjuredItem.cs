namespace GildedRoseKata
{
    public class ConjuredItem(Item item) : AbstractBaseItem(item)
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (SellIn >= 0)
            {
                Quality -= 2;
            }
            else
            {
                Quality -= 4;
            }

            if (Quality < 0)
            {
                Quality = 0;
            }
        }
    }
}
