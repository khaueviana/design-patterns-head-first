using System.Collections.Generic;
using PatternAbstractFactory.Ingredient.CheeseIngredient;
using PatternAbstractFactory.Ingredient.ClamIngredient;
using PatternAbstractFactory.Ingredient.DoughIngredient;
using PatternAbstractFactory.Ingredient.PepperoniIngredient;
using PatternAbstractFactory.Ingredient.SauceIngredient;
using PatternAbstractFactory.Ingredient.VeggieIngredient;

namespace PatternAbstractFactory.Ingredient
{
    public interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggie> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clam CreateClam();
    }
}
