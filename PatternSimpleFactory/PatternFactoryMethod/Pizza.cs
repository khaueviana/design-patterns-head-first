using System;
using System.Collections.Generic;

namespace PatternFactoryMethod
{
    public abstract class Pizza
    {
        protected String name;
        protected String dough;
        protected String sauce;
        protected List<String> toppings = new List<String>();

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Toussing dough");
            Console.WriteLine("Adding sauce");
            Console.WriteLine("Adding toppings: ");

            foreach (string t in toppings)
            {
                Console.WriteLine(" " + t);
            }
        }

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

        public String GetName()
        {
            return name;
        }
    }
}
