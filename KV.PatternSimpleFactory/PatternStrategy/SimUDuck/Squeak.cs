using System;

namespace PatternStrategy.SimUDuck
{
    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Pato guinchando!");
        }
    }
}