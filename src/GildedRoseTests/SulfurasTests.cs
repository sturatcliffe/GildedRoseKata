using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class SulfurasTests
    {
        [Fact]
        public void UpdateQuality_Should_Not_Change_SellIn_Or_Quality()
        {
            var item = new SulfurasItem(new Item { SellIn = 5, Quality = 10 });

            item.UpdateQuality();

            Assert.Equal(5, item.SellIn);
            Assert.Equal(10, item.Quality);
        }
    }
}
