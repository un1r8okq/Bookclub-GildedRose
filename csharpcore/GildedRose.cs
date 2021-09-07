using System;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        //TODO: refactor to not have magic strings everywhere
        public void UpdateQuality()
        {
            var class1 = new Class1();
            foreach (var item in Items)
            {
                class1.UpdateQuality(item);
            }
        }
    }
}
