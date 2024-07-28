namespace GildedRoseKata
{
    public class BackstagePassItem(Item item) : AbstractBaseItem(item)
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn <= 5)
            {
                Quality += 3;
            }
            else if (SellIn <= 10)
            {
                Quality += 2;
            }
            else
            {
                Quality += 1;
            }

            if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}
