using System;

namespace KV.PatternIteratorComposite
{
    public class DinnerMenuIterator : Iterator
    {
        private MenuItem[] Items;
        private int position = 0;

        public bool HasNext()
        {
            bool ret;

            if (position >= Items.Length || Items[position] == null)
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

        public DinnerMenuIterator(MenuItem[] items)
        {
            Items = items;
        }
    }
}
