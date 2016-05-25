using KV.PatternAbstractFactory.Ingredient;
using KV.PatternAbstractFactory.Pizza;

namespace KV.PatternAbstractFactory.Store
{
    public class NYPizzaStore : PizzaStore
    {
        protected override PizzaAbstract CreatePizza(string type)
        {
            PizzaAbstract pizza = null;

            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Pizza de Queijo no Estilo de Nova York");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Pizza de Mariscos no Estilo de Nova York");
            }

            return pizza;
        }
    }
}
