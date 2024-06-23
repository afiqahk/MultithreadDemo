using MultithreadConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Processor : ThreadManaged
    {
        public Processor(
            Utils.ExitCallback exitCallback
            ) : base("processor", exitCallback)
        { }
        internal void RunProcessor(object? obj)
        {
            Console.WriteLine($"[{Name}] Thread started...");
            if (obj is null)
            {
                ExitFail("ct is null");
                return;
            }
            var ct = (CancellationToken)obj;
            while (!ct.IsCancellationRequested)
            {
            }
            ExitSuccess();
            return;
        }
    }
}
