﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KV.PatternProxy
{
    class Program
    {
        /// <summary>
        /// MainApp startup class for Real-World 
        /// Proxy Design Pattern.
        /// </summary>
        class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>
            static void Main()
            {
                // Create math proxy
                MathProxy proxy = new MathProxy();

                // Do the math
                Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
                Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
                Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
                Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

                // Wait for user
                Console.ReadKey();
            }
        }        
    }
}
