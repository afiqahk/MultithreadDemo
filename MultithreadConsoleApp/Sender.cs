using MultithreadConsoleApp.Classes;
using MultithreadConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Sender : ThreadManaged, ICancellable
    {
        public CancellationToken Token { get; set; }
        public Sender(
            Utils.ExitCallback exitCallback
            ) : base("sender", exitCallback)
        {}

        public void Run(object? obj)
        {
            if (!OnStarted(obj)) return;
            int i = 0;
            while(!Token.IsCancellationRequested)
            {
                Console.WriteLine($"[{Name}] i={i}");
                i++;
                Thread.Sleep(2000);
            }
            ExitSuccess();
            return;
        }
    }
}
