using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using csharpcore.Rules;

namespace csharpcore
{
    public class Class1
    {
        private readonly Rule firstRule;
        private readonly List<Rule> rules = new List<Rule>();

        public Class1()
        {
            firstRule = new SulfurasRule(
                new BackstagePassRule( 
                    new AgedBrieRule(
                        new ConjuredItemRule(
                    new DefaultRule(null)))));

            rules.Add(new SulfurasRule(null));
            rules.Add(new BackstagePassRule(null));
            rules.Add(new AgedBrieRule(null));
            rules.Add(new ConjuredItemRule(null));
            rules.Add(new DefaultRule(null));
            
        }

        public void UpdateQuality(Item item)
        {

            rules.First(c => c.HandlesItem(item)).UpdateQuality(item);

            //firstRule.UpdateItem(item);
        }
    }

    internal class ItemWrapper
    {
        public Item Item { get; private set; }

        public ItemWrapper(Item item)
        {
            Item = item;
        }

        public int QualityDelta { get; set; }
    }
}


