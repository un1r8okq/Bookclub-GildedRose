using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Rules
{
    public class BackstagePassRule:Rule
    {
        public BackstagePassRule(Rule nextRule) : base(nextRule)
        {
        }

        public override bool HandlesItem(Item item)
        {
            return (item.Name == "Backstage passes to a TAFKAL80ETC concert");
        }

        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1; //1

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }
    }
}
