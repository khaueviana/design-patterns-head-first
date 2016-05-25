using System;

namespace PatternCommand.Commands
{
    public class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("No Command");
        }

        public void Undo()
        {
            Console.WriteLine("No Command");
        }
    }
}