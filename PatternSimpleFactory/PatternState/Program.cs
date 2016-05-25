using System;

namespace PatternState
{
    class Program
    {
        static void Main(string[] args)
        {
            //firstTest();

            finalTest();

            Console.ReadKey();
        }

        private static void finalTest()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }

        private static void firstTest()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine("\n---------------------\n");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("\n---------------------\n");

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("\n---------------------\n");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            Console.WriteLine("\n---------------------\n");

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("\n---------------------\n");
        }
    }
}