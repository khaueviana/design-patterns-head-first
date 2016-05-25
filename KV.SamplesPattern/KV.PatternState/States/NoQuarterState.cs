using System;

namespace KV.PatternState.States
{
    public class NoQuarterState : State
    {
        private GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        
        public void InsertQuarter()
        {
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
            Console.WriteLine("You inserted a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}