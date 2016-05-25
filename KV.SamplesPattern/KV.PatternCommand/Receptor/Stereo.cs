using System;

namespace KV.PatternCommand.Receptor
{
    public class Stereo
    {
        private string name;

        public Stereo(string name)
        {
            this.name = name;
        }

        public void On()
        {
            Console.WriteLine(name + " Stereo is On");
        }

        public void Off()
        {
            Console.WriteLine(name + " Stereo is Off");
        }

        public void SetCd()
        {
            Console.WriteLine(name + " CD is Set");
        }

        public void SetDvd()
        {
            Console.WriteLine(name + " DVD is Set");
        }

        public void SetRadio()
        {
            Console.WriteLine(name + " Radio is Set");
        }

        public void SetVolume()
        {
            Console.WriteLine(name + " Volume is Set");
        }
    }
}
