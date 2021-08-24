using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace csharpcore
{
    public class AgedBrieTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        public void WhenNotDueToBeSold_AndADayPasses_QualityIncreasesByOne(int sellIn)
        {
            var item = new Item
            {
                Name = "Aged Brie",
                SellIn = sellIn,
                Quality = 6,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(7, item.Quality);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void WhenDueToBeSold_AndADayPasses_QualityIncreasesByTwo(int sellIn)
        {
            var item = new Item
            {
                Name = "Aged Brie",
                SellIn = sellIn,
                Quality = 6,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(8, item.Quality);
        }

        [Fact]
        public void GivenAnItemThatIncreasesInQualityOverTime__WhenADayPasses__TheQualityDoesntGoAbove50()
        {
            // TODO make this do something
            var item = new Item
            {
                Name = itemName,
                SellIn = 10,
                Quality = 55,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(54, item.Quality);
        }
    }
}