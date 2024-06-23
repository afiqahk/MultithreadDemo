using MultithreadConsoleApp.Classes;
using MultithreadConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Processor : ThreadManaged, ICancellable
    {
        public CancellationToken Token { get; set; }
        public Processor(
            Utils.ExitCallback exitCallback
            ) : base("processor", exitCallback)
        { }

        public void Run(object? obj)
        {
            if(!OnStarted(obj)) return;            
            while (!Token.IsCancellationRequested)
            {
            }
            ExitSuccess();
            return;
        }
    }
}
