using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class ConjuredItemTests
    {
        [Fact]
        public void UpdateQuality_Should_Decrease_SellIn()
        {
            var item = GetItem(5, 10);

            item.UpdateQuality();

            Assert.Equal(4, item.SellIn);
        }

        [Fact]
        public void UpdateQuality_Should_Decrease_Quality()
        {
            var item = GetItem(5, 10);

            item.UpdateQuality();

            Assert.Equal(8, item.Quality);
        }

        [Fact]
        public void UpdateQuality_Should_Not_Decrease_Quality_Below_Zero()
        {
            var item = GetItem(5, 0);

            item.UpdateQuality();

            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void UpdateQuality_Should_Decrease_Quality_Twice_As_Fast_When_SellIn_Is_Negative()
        {
            var item = GetItem(-1, 10);

            item.UpdateQuality();

            Assert.Equal(6, item.Quality);
        }

        private ConjuredItem GetItem(int sellIn, int quality)
        {
            return new ConjuredItem(new Item { Name = "Test", SellIn = sellIn, Quality = quality });
        }
    }
}
