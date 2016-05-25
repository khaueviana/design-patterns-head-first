using System;

namespace PatternSimpleFactory
{
    public class PizzaStore
    {
        public Pizza OrderPizza(String type)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();

            Pizza pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }    
    }
}