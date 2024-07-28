namespace GildedRoseKata
{
    public class StandardItem(Item item) : AbstractBaseItem(item)
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (Quality > 0)
            {
                if (SellIn >= 0)
                {
                    Quality -= 1;
                }
                else
                {
                    Quality -= 2;
                }
            }
        }
    }
}
