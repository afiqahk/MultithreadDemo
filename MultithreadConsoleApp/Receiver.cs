using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal static class Receiver
    {
        internal static void RunReceiver()
        {
            Console.WriteLine("Receiver started...");
            Thread.Sleep(1000);
            Console.WriteLine("Receiver exiting...");
        }
    }
}
