using System;

namespace PatternComposite
{
    public class MenuItem : MenuComponent
    {
        private string name;
        private string description;
        private bool isVegetarian;
        private decimal price;

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override decimal GetPrice()
        {
            return price;
        }

        public override bool IsVegetarian()
        {
            return isVegetarian;
        }

        public override void Print()
        {
            Console.WriteLine(" # Name: " + name);

            if (isVegetarian)
            {
                Console.WriteLine("(v)");
            }

            Console.WriteLine(" - Price: " + price);
            Console.WriteLine(" - Description: " + description);
        }

        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            this.name = name;
            this.description = description;
            this.isVegetarian = isVegetarian;
            this.price = price;
        }
    }
}
