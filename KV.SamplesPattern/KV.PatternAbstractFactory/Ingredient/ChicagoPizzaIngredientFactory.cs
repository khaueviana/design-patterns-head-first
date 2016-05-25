using System.Collections.Generic;
using KV.PatternAbstractFactory.Ingredient.CheeseIngredient;
using KV.PatternAbstractFactory.Ingredient.ClamIngredient;
using KV.PatternAbstractFactory.Ingredient.DoughIngredient;
using KV.PatternAbstractFactory.Ingredient.PepperoniIngredient;
using KV.PatternAbstractFactory.Ingredient.SauceIngredient;
using KV.PatternAbstractFactory.Ingredient.VeggieIngredient;

namespace KV.PatternAbstractFactory.Ingredient
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