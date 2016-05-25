using System;

namespace KV.PatternSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore();

            Pizza cheese = pizzaStore.OrderPizza("cheese");
            
            Pizza pepperoni = pizzaStore.OrderPizza("pepperoni");

            Console.ReadKey();
        }
    }
}
