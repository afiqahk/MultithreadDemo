using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Sender
    {
        private Utils.ExitCallback _exitCallback;
        internal Sender(
            Utils.ExitCallback exitCallback
            )
        {
            _exitCallback = exitCallback;
        }
        internal void RunSender(object? obj)
        {
            Console.WriteLine("[sender] Thread started...");
            if (obj is null)
            {
                _exitCallback("sender", false, "ct is null");
                return;
            }

            var ct = (CancellationToken)obj;
            int i = 0;
            while(!ct.IsCancellationRequested)
            {
                Console.WriteLine($"[sender] i={i}");
                i++;
                Thread.Sleep(2000);
            }
            _exitCallback("sender", true, null);
            return;
        }
    }
}
