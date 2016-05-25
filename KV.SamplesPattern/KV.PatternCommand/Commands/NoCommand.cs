using System;

namespace KV.PatternCommand.Commands
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