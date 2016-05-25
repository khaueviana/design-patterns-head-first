using KV.PatternCommand.Receptor;

namespace KV.PatternCommand.Commands
{
    public class StereoOnCommand : Command
    {
        private Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}