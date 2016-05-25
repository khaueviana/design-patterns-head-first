using System;

namespace KV.PatternStrategy.SimUDuck
{
    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Pato guinchando!");
        }
    }
}