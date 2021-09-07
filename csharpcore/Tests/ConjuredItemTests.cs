using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace csharpcore.Tests
{
    public class ConjuredItemTests
    {
        [Fact]
        public void BasicConjuredItemTest()
        {
            var item = new Item
            {
                Name = "Conjured Item",
                SellIn = 10,
                Quality = 10,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(8, item.Quality);

        }
    }
}
