using System;
using System.Collections.Generic;
using KV.PatternAbstractFactory.Ingredient.CheeseIngredient;
using KV.PatternAbstractFactory.Ingredient.ClamIngredient;
using KV.PatternAbstractFactory.Ingredient.DoughIngredient;
using KV.PatternAbstractFactory.Ingredient.PepperoniIngredient;
using KV.PatternAbstractFactory.Ingredient.SauceIngredient;
using KV.PatternAbstractFactory.Ingredient.VeggieIngredient;

namespace KV.PatternAbstractFactory.Pizza
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
