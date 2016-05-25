using System;

namespace PatternSimpleFactory
{
    public class ClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare Clam Pizza");
        }

        public override void Bake()
        {
            Console.WriteLine("Bake Clam Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cut Clam Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Box Clam Pizza");
        }
    }
}