using System;
using System.Collections.Generic;
using PatternAbstractFactory.Ingredient.CheeseIngredient;
using PatternAbstractFactory.Ingredient.ClamIngredient;
using PatternAbstractFactory.Ingredient.DoughIngredient;
using PatternAbstractFactory.Ingredient.PepperoniIngredient;
using PatternAbstractFactory.Ingredient.SauceIngredient;
using PatternAbstractFactory.Ingredient.VeggieIngredient;

namespace PatternAbstractFactory.Pizza
{
    public abstract class PizzaAbstract
    {
        private String name;
        protected Dough dough;
        protected Sauce sauce;
        protected List<Veggie> veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clam clam;

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void SetName(String n)
        {
            name = n;
        }

        public String GetName()
        {
            return name;
        }
    }
}
