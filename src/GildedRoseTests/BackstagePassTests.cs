using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class BackstagePassTests
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
            var item = GetItem(12, 10);

            item.UpdateQuality();

            Assert.Equal(11, item.Quality);
        }

        [Fact]
        public void UpdateQuality_Should_Increase_Quality_By_Two_When_SellIn_Is_Ten_Or_Less()
        {
            var item = GetItem(10, 10);

            item.UpdateQuality();

            Assert.Equal(12, item.Quality);
        }

        [Fact]
        public void UpdateQuality_Should_Increase_Quality_By_Three_When_SellIn_Is_Five_Or_Less()
        {
            var item = GetItem(5, 10);

            item.UpdateQuality();

            Assert.Equal(13, item.Quality);
        }

        [Fact]
        public void UpdateQuality_Should_Not_Increase_Quality_Above_Fifty()
        {
            var item = GetItem(12, 49);

            item.UpdateQuality();

            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void UpdateQuality_Should_Decrease_Quality_To_Zero_When_SellIn_Is_Negative()
        {
            var item = GetItem(-1, 10);

            item.UpdateQuality();

            Assert.Equal(0, item.Quality);
        }

        private BackstagePassItem GetItem(int sellIn, int quality)
        {
            return new BackstagePassItem(new Item { Name = "Test", SellIn = sellIn, Quality = quality });
        }
    }
}
