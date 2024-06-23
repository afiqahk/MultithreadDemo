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

        internal Receiver(
            Utils.ExitCallback exitCallback
            )
        {
            _exitCallback = exitCallback;
        }
        internal void RunReceiver(object? obj)
        {
            Console.WriteLine("[receiver] Thread started...");
            if (obj is null)
            {
                _exitCallback("receiver", false, "ct is null");
                return;
            }
            var ct = (CancellationToken)obj;
            while (!ct.IsCancellationRequested)
            {
            }
            _exitCallback("receiver", true, null);
            return;
        }
    }
}
