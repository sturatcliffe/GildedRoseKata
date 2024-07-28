using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class AgedBrieTests
    {
        [Fact]
        public void UpdateQuality_Should_Decrease_SellIn()
        {
            var item = GetItem(5, 10);

            item.UpdateQuality();

            Assert.Equal(4, item.SellIn);
        }

        [Fact]
        public void UpdateQuality_Should_Increase_Quality()
        {
            var item = GetItem(2, 0);

            item.UpdateQuality();

            Assert.Equal(1, item.Quality);
        }

        [Fact]
        public void UpdateQuality_Should_Not_Increase_Quality_Above_Fifty()
        {
            var item = GetItem(5, 50);

            item.UpdateQuality();

            Assert.Equal(50, item.Quality);
        }

        private AgedBrieItem GetItem(int sellIn, int quality)
        {
            return new AgedBrieItem(new Item { Name = "Test", SellIn = sellIn, Quality = quality });
        }
    }
}
