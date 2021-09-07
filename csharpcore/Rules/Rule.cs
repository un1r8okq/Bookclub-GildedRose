using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore
{
    public abstract class Rule
    {
        private readonly Rule _nextRule;

        public Rule(Rule nextRule)
        {
            _nextRule = nextRule;
        }


        public abstract bool HandlesItem(Item item);

        public abstract void UpdateQuality(Item item);

        public void UpdateItem(Item item)
        {
            if(HandlesItem(item))
            {
                UpdateQuality(item);
            }
            else
            {
                _nextRule.UpdateItem(item);
            }
        }
    }
}
