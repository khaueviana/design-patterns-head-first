using System;
using KV.PatternAbstractFactory.Pizza;

namespace KV.PatternAbstractFactory.Store
{
    public abstract class PizzaStore
    {
        public PizzaAbstract OrderPizza(String type)
        {
            PizzaAbstract pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract PizzaAbstract CreatePizza(String type);
    }
}