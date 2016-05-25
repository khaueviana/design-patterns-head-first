namespace KV.PatternCommand.Commands
{
    public class MacroCommand : Command
    {
        private Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (Command command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (Command command in commands)
            {
                command.Undo();
            }
        }
    }
}
