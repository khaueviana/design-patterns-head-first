using System;

namespace KV.PatternIteratorComposite
{
    public class DinnerMenu : Menu
    {
        private const int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private MenuItem[] menuItems;

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Menu está completo, não é permitido adicionar mais itens.");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems += 1;
            }
        }

        public Iterator CreateIterator()
        {
            return new DinnerMenuIterator(menuItems);
        }

        public DinnerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("P1", "P1 é show", true, 2.99M);
            AddItem("P2", "P2 é show", true, 3.99M);
            AddItem("P3", "P3 é show", true, 4.99M);
            AddItem("P4", "P4 é show", true, 5.99M);
        }
    }
}