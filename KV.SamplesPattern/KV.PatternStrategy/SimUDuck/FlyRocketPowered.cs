using System;

namespace KV.PatternStrategy.SimUDuck
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Estou voando como um foguete!");
        }
    }
}