using System;
using KV.PatternAbstractFactory.Pizza;
using KV.PatternAbstractFactory.Store;

namespace KV.PatternAbstractFactory
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