using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Receiver
    {
        private readonly Utils.ExitCallback _exitCallback;
        private readonly string _name = "receiver";
        internal Receiver(
            Utils.ExitCallback exitCallback
            )
        {
            _exitCallback = exitCallback;
        }
        internal void RunReceiver(object? obj)
        {
            Console.WriteLine($"[{_name}] Thread started...");
            if (obj is null)
            {
                _exitCallback(_name, false, "ct is null");
                return;
            }
            var ct = (CancellationToken)obj;
            while (!ct.IsCancellationRequested)
            {
            }
            _exitCallback(_name, true, null);
            return;
        }
    }
}
