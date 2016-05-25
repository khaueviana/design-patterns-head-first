using System;

namespace PatternSimpleFactory
{
    public class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare Veggie Pizza");
        }

        public override void Bake()
        {
            Console.WriteLine("Bake Veggie Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cut Veggie Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Box Veggie Pizza");
        }
    }
}