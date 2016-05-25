using System;

namespace PatternStrategy.SimUDuck
{
    public class SimpleQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Pato grasnando");
        }
    }
}