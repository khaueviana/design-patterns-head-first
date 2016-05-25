using System;

namespace KV.PatternStrategy.SimUDuck
{
    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Faz nada!");
        }
    }
}