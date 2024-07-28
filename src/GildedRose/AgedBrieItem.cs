namespace GildedRoseKata
{
    public class AgedBrieItem(Item item) : AbstractBaseItem(item)
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (Quality < 50)
            {
                Quality += 1;
            }
        }
    }
}
