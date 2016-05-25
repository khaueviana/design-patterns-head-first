using System.Collections.Generic;
using PatternAbstractFactory.Ingredient.CheeseIngredient;
using PatternAbstractFactory.Ingredient.ClamIngredient;
using PatternAbstractFactory.Ingredient.DoughIngredient;
using PatternAbstractFactory.Ingredient.PepperoniIngredient;
using PatternAbstractFactory.Ingredient.SauceIngredient;
using PatternAbstractFactory.Ingredient.VeggieIngredient;

namespace PatternAbstractFactory.Ingredient
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggie> CreateVeggies()
        {
            List<Veggie> ret = new List<Veggie>();
            ret.Add(new Garlic());
            ret.Add(new Mushroom());
            ret.Add(new Onion());
            ret.Add(new RedPepper());

            return ret;
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
    }
}