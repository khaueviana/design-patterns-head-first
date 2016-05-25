using KV.PatternCommand.Receptor;

namespace KV.PatternCommand.Commands
{
    public class TVOffCommand : Command
    {
        private TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.Off();
        }

        public void Undo()
        {
            tv.On();
        }
    }
}