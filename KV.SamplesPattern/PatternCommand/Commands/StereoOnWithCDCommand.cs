using System;
using PatternCommand.Receptor;

namespace PatternCommand.Commands
{
    public class StereoOnWithCDCommand : Command
    {
        private Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}