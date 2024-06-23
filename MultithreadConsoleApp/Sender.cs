using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal static class Sender
    {
        internal static void RunSender()
        {
            Console.WriteLine("Sender started...");
            Thread.Sleep(1000);
            Console.WriteLine("Sender exiting...");
        }
    }
}
