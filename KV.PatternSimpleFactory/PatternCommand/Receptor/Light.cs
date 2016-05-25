using System;

namespace PatternCommand.Receptor
{
    public class Light
    {
        private string name;

        public Light()
        {
        }

        public Light(String name)
        {
            this.name = name;
        }

        public void On()
        {
            Console.WriteLine(name + " Light is On");
        }

        public void Off()
        {
            Console.WriteLine(name + " Light is Off");
        }
    }
}