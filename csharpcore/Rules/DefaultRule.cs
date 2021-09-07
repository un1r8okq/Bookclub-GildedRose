using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Rules
{
    public class DefaultRule:Rule
    {
        public DefaultRule(Rule nextRule) : base(nextRule)
        {
        }

        public override void UpdateQuality(Item item)
        {

            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
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
    

    public override bool HandlesItem(Item item)
    {
        return true;
    }

    
    }
}
