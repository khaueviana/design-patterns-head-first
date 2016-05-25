namespace PatternFactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NYCheesePizza();
            }

            return pizza;
        }
    }
}
