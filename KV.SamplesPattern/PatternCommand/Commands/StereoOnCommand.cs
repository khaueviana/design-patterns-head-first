using PatternCommand.Receptor;

namespace PatternCommand.Commands
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