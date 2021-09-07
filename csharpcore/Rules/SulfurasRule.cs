using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    public class SulfurasRule:Rule
    {

        public override void UpdateQuality(Item item)
        {
            Console.WriteLine("Try raids today");
        }

        public override bool HandlesItem(Item item)
        {
            return (item.Name == "Sulfuras, Hand of Ragnaros");
        }

        public SulfurasRule(Rule nextRule) : base(nextRule)
        {
        }
    }
}
