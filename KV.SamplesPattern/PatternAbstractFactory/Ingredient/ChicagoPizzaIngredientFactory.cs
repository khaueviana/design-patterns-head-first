using System.Collections.Generic;
using PatternAbstractFactory.Ingredient.CheeseIngredient;
using PatternAbstractFactory.Ingredient.ClamIngredient;
using PatternAbstractFactory.Ingredient.DoughIngredient;
using PatternAbstractFactory.Ingredient.PepperoniIngredient;
using PatternAbstractFactory.Ingredient.SauceIngredient;
using PatternAbstractFactory.Ingredient.VeggieIngredient;

namespace PatternAbstractFactory.Ingredient
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
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
            return new FrozenClam();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
    }
}