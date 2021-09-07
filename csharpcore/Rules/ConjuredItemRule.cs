using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Rules
{
    public class ConjuredItemRule:Rule
    {
        public ConjuredItemRule(Rule nextRule) : base(nextRule)
        {
        }

        public override bool HandlesItem(Item item)
        {
            return item.Name.StartsWith("Conjured");
        }

        public override void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }


            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {

                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }
    }
}
