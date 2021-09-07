using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace csharpcore
{
    public class BackstagePassesTests
    {
        [Fact]
        public void GivenABackStagePass__WhenThereAreMoreThen10SellInDays__ThenQualityIncreasesByOne()
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 11,
                Quality = 6,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(7, item.Quality);
        }

        [Theory]
        [InlineData(6, 15, 17)]
        [InlineData(8, 38, 40)]
        [InlineData(10, 2, 4)]
        public void GivenABackStagePass__WhenThereAreBetween6and10SellInDays__ThenQualityIncreasesByTwo(int sellIn,
            int initialQuality, int expectedQuality)
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = sellIn,
                Quality = initialQuality,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(expectedQuality, item.Quality);
        }

        [Theory]
        [InlineData(5, 15, 18)]
        [InlineData(2, 38, 41)]
        [InlineData(1, 2, 5)]
        public void GivenABackStagePass__WhenThereAreBetween5And1__ThenQualityIncreasesByThree(int sellIn,
            int initialQuality, int expectedQuality)
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = sellIn,
                Quality = initialQuality,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(expectedQuality, item.Quality);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(-1, 5)]
        [InlineData(-30, 15)]
        [InlineData(int.MinValue + 1, 5)]
        public void GivenABackStagePass__WhenTheSellInIsBelow1__ThenQualityIs0(int sellIn, int initialQuality)
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = sellIn,
                Quality = initialQuality,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, item.Quality);
        }
        
        [Theory]
        [InlineData("Backstage passes to a TAFKAL80ETC concert")]
        public void GivenAnItemThatIncreasesInQualityOverTime__WhenADayPasses__TheQualityDoesntGoAbove50(string itemName)
        {
            var item = new Item
            {
                Name = itemName,
                SellIn = 10,
                Quality = 55,
            };
            var items = new List<Item> { item };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(55, item.Quality);
        }
    }
    
    
}