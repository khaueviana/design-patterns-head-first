using System;

namespace KV.PatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            new SimpleRemoteLoader().Load();
            new RemoteLoader().Load();

            Console.ReadKey();
        }
    }
}