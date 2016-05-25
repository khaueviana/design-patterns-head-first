using System;

namespace PatternStrategy.SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new SimpleQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Eu sou um Model Duck");
        }
    }
}