using PatternCommand.Receptor;

namespace PatternCommand.Commands
{
    public class TVOnCommand : Command
    {
        private TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}