using KV.PatternCommand.Receptor;

namespace KV.PatternCommand.Commands
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