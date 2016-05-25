using System;

namespace PatternStrategy.SimUDuck
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Pássaro voando!");
        }
    }
}