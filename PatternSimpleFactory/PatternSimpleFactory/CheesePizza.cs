using System;

namespace PatternSimpleFactory
{
    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare Cheese Pizza");
        }

        public override void Bake()
        {
            Console.WriteLine("Bake Cheese Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cut Cheese Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Box Cheese Pizza");
        }
    }
}