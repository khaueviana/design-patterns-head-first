using System;
using KV.PatternAbstractFactory.Ingredient;

namespace KV.PatternAbstractFactory.Pizza
{
    public class ClamPizza : PizzaAbstract
    {
        private PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + GetName());
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clam = ingredientFactory.CreateClam();
        }
    }
}