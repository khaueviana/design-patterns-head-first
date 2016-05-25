using System.Collections.Generic;

namespace KV.PatternIteratorComposite
{
    public class PancakeHouseMenuIterator : Iterator
    {
        private List<MenuItem> Items;
        private int position = 0;

        public bool HasNext()
        {
            bool ret;

            if (position >= Items.Count || Items[position] == null)
            {
                ret = false;
            }
            else
            {
                ret = true;
            }

            return ret;
        }

        public object Next()
        {
            MenuItem menuItem = Items[position];
            position = position + 1;
            return menuItem;
        }

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            Items = items;
        }

    }
}