using System;

namespace PatternCommand.Receptor
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is Up");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Down");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door was Stopped");
        }

        public void LighOn()
        {
            Console.WriteLine("Light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
