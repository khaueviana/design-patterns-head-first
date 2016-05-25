using System;

namespace PatternIteratorComposite
{
    public class Waitress
    {
        private Menu pancakeHouseMenu;
        private Menu dinerMenu;

        public void PrintMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            Iterator dinerIterator = dinerMenu.CreateIterator();

            PrintMenu(pancakeIterator);
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();

                Console.WriteLine(menuItem.Name + ", ");
                Console.WriteLine(menuItem.Price + ", ");
                Console.WriteLine(menuItem.Description);

            }
        }

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
    }
}
