using System;

namespace KV.PatternStrategy.SimUDuck
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Pássaro voando!");
        }
    }
}