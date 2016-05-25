using System;
using PatternAbstractFactory.Pizza;
using PatternAbstractFactory.Store;

namespace PatternAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pizza Chicago\n");

            ChicagoPizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            PizzaAbstract cheeseChicago = chicagoPizzaStore.OrderPizza("cheese");
            PizzaAbstract clamChicago = chicagoPizzaStore.OrderPizza("clam");

            Console.WriteLine("\nPizza New York\n");

            NYPizzaStore nyPizzaStore = new NYPizzaStore();

            PizzaAbstract cheeseNY = nyPizzaStore.OrderPizza("cheese");
            PizzaAbstract clamNY = nyPizzaStore.OrderPizza("clam");

            Console.ReadKey();
        }
    }
}