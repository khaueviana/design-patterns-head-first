using System;
using KV.PatternAbstractFactory.Ingredient;

namespace KV.PatternAbstractFactory.Pizza
{
    public class CheesePizza : PizzaAbstract
    {
        private PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + GetName());
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
        }
    }
}