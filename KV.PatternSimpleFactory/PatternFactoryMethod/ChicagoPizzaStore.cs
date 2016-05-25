namespace PatternFactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new ChicagoCheesePizza();
            }

            return pizza;
        }
    }
}