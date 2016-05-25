using KV.PatternAbstractFactory.Ingredient;
using KV.PatternAbstractFactory.Pizza;

namespace KV.PatternAbstractFactory.Store
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override PizzaAbstract CreatePizza(string type)
        {
            PizzaAbstract pizza = null;

            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Pizza de Queijo no Estilo de Chicago");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Pizza de Mariscos no Estilo de Chicago");
            }

            return pizza;
        }
    }
}