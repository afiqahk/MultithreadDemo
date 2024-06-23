using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal static class Processor
    {
        internal static void RunProcessor()
        {
            Console.WriteLine("Processor started...");
            Thread.Sleep(1000);
            Console.WriteLine("Processor exiting...");
        }
    }
}
