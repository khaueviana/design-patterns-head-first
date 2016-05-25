using System;

namespace KV.PatternState.States
{
    public class WinnerState : State
    {
        private GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get your another gumball");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");

            if (gumballMachine.GetCount() == 0)
            {
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
            else
            {
                gumballMachine.ReleaseBall();

                if (gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");

                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
        }
    }
}