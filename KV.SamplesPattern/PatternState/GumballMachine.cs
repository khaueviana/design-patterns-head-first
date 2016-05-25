using System;
using PatternState.States;

namespace PatternState
{
    public class GumballMachine
    {
        private State soldOutState;
        private State noQuarterState;
        private State hasQuarterState;
        private State soldState;
        private State winnerState;

        private State currentState = null;
        private int count;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            currentState = soldOutState;

            count = numberGumballs;

            if (count > 0)
            {
                currentState = noQuarterState;
            }
        }

        public void InsertQuarter()
        {
            currentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            currentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            currentState.TurnCrank();
            currentState.Dispense();
        }

        public State GetSoldOutState()
        {
            return soldOutState;
        }

        public State GetNoQuarterState()
        {
            return noQuarterState;
        }

        public State GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public State GetSoldState()
        {
            return soldState;
        }

        public State GetWinnerState()
        {
            return winnerState;
        }

        public void SetState(State state)
        {
            currentState = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");

            if (count != 0)
            {
                count -= 1;
            }
        }

        public int GetCount()
        {
            return count;
        }
    }
}
