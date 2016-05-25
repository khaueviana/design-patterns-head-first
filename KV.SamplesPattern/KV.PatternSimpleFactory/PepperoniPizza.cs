using System;

namespace KV.PatternSimpleFactory
{
    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare Pepperoni Pizza");
        }

        public override void Bake()
        {
            Console.WriteLine("Bake Pepperoni Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cut Pepperoni Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Box Pepperoni Pizza");
        }
    }
}