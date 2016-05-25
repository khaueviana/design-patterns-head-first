using System.Collections.Generic;

namespace KV.PatternIteratorComposite
{
    public class PancakeHouseMenu : Menu
    {
        private List<MenuItem> menuItems;

        public Iterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            menuItems.Add(new MenuItem("P1", "P1 Legal", true, 2.99M));
            menuItems.Add(new MenuItem("P2", "P2 Legal", false, 3.99M));
            menuItems.Add(new MenuItem("P3", "P3 Legal", true, 4.99M));
            menuItems.Add(new MenuItem("P4", "P4 Legal", true, 5.99M));
        }
    }
}