using System;

namespace KV.PatternStrategy.SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new SimpleQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Eu sou um Mallard Duck");
        }
    }
}