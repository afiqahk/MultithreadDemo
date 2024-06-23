using MultithreadConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Sender : ThreadManaged
    {
        public Sender(
            Utils.ExitCallback exitCallback
            ) : base("sender", exitCallback)
        {}
        internal void RunSender(object? obj)
        {
            Console.WriteLine($"[{Name}] Thread started...");
            if (obj is null)
            {
                ExitFail("ct is null");
                return;
            }

            var ct = (CancellationToken)obj;
            int i = 0;
            while(!ct.IsCancellationRequested)
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
