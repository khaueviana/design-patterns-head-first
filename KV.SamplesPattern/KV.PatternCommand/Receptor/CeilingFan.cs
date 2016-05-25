using System;

namespace KV.PatternCommand.Receptor
{
    public class CeilingFan
    {
        private string name;
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF;
        private int speed;

        public CeilingFan(string name)
        {
            this.name = name;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine(name + " High Ceiling Fan");
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine(name + " Medium Ceiling Fan");
        }

        public void Low()
        {
            speed = LOW;
            Console.WriteLine(name + " Low Ceiling Fan");
        }
        
        public void Off()
        {
            speed = OFF;
            Console.WriteLine(name + " Ceiling Fan is Off");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}