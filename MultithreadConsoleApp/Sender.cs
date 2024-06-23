using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Sender
    {
        private readonly Utils.ExitCallback _exitCallback;
        private readonly string _name = "sender";

        internal Sender(
            Utils.ExitCallback exitCallback
            )
        {
            _exitCallback = exitCallback;
        }
        internal void RunSender(object? obj)
        {
            Console.WriteLine($"[{_name}] Thread started...");
            if (obj is null)
            {
                _exitCallback(_name, false, "ct is null");
                return;
            }

            var ct = (CancellationToken)obj;
            int i = 0;
            while(!ct.IsCancellationRequested)
            {
                Console.WriteLine($"[{_name}] i={i}");
                i++;
                Thread.Sleep(2000);
            }
            _exitCallback(_name, true, null);
            return;
        }
    }
}
