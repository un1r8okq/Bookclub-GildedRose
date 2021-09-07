using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Rules
{
    public class AgedBrieRule:Rule
    {
        public AgedBrieRule(Rule nextRule) : base(nextRule)
        {
        }

        public override bool HandlesItem(Item item)
        {
            return item.Name == "Aged Brie";
        }

        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1; //1

            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}
