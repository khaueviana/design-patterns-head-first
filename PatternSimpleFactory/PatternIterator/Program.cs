using System;

namespace PatternIteratorComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinnerMenu dinnerMenu = new DinnerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinnerMenu);

            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}