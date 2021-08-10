using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace csharpcore
{
	public class BackstagePassesTests
	{
		public void WhenNotDueToBeSold_AndADayPasses_QualityIncreasesByOne(int sellIn)
		{
			// TODO: Start working on this test next week
			var item = new Item
			{
				Name = "Backstage passes",
				SellIn = sellIn,
				Quality = 6,
			};
			var items = new List<Item> { item };
			var app = new GildedRose(items);

			app.UpdateQuality();

			Assert.Equal(7, item.Quality);
		}
	}
}
