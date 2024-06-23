using MultithreadConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Receiver : ThreadManaged
    {
        public Receiver(
            Utils.ExitCallback exitCallback
            ) : base("receiver", exitCallback)
        { }
        internal void RunReceiver(object? obj)
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
