using System;

namespace PatternComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFÉ MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti", true, 3.89M));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple Pie", true, 1.59M));

            pancakeHouseMenu.Add(new MenuItem("p1", "p2", true, 1.59M));

            cafeMenu.Add(new MenuItem("p1", "p2", true, 1.59M));

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}