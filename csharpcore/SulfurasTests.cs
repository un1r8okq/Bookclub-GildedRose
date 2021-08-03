using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace csharpcore
{
    public class SulfurasTests
    {
        [Fact]
        public void SulfurasDoesNothing()
        {
            var item = new Item
            {
                Name = "Sulfuras, Hand of Ragnaros",
                SellIn = 10,
                Quality = 80,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, item.Quality);
        }
    }
}