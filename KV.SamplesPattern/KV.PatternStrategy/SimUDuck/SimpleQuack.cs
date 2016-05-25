using System;

namespace KV.PatternStrategy.SimUDuck
{
    public class SimpleQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Pato grasnando");
        }
    }
}