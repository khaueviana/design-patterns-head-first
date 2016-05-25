using System;

namespace KV.PatternAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();

            WildTurkey wildTurkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Console.WriteLine("The turkey says...");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("\nThe Duck Says...");
            TestDuck(mallardDuck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            Console.ReadKey();

        }

        static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
