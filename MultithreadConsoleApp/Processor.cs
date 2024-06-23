using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Processor
    {
        private readonly Utils.ExitCallback _exitCallback;

        internal Processor(
            Utils.ExitCallback exitCallback
            )
        {
            _exitCallback = exitCallback;
        }
        internal void RunProcessor(object? obj)
        {
            Console.WriteLine("[processor] Thread started...");
            if (obj is null)
            {
                _exitCallback("processor", false, "ct is null");
                return;
            }
            var ct = (CancellationToken)obj;
            while (!ct.IsCancellationRequested)
            {
            }
            _exitCallback("processor", true, null);
            return;
        }
    }
}
