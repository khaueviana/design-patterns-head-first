using System.Collections.Generic;
using KV.PatternAbstractFactory.Ingredient.CheeseIngredient;
using KV.PatternAbstractFactory.Ingredient.ClamIngredient;
using KV.PatternAbstractFactory.Ingredient.DoughIngredient;
using KV.PatternAbstractFactory.Ingredient.PepperoniIngredient;
using KV.PatternAbstractFactory.Ingredient.SauceIngredient;
using KV.PatternAbstractFactory.Ingredient.VeggieIngredient;

namespace KV.PatternAbstractFactory.Ingredient
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
