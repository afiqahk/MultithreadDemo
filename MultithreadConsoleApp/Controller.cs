using MultithreadConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Controller : ThreadManaged
    {
        private readonly CancellationTokenSource _cancellationTokenSource;

        public Controller(
            CancellationTokenSource cancellationTokenSource,
            Utils.ExitCallback exitCallback
            ) : base("controller", exitCallback)
        {
            _cancellationTokenSource = cancellationTokenSource;
        }
        internal void RunController()
        {
            Console.WriteLine($"[{Name}] Thread started...");
            Console.WriteLine($"[{Name}] Press 'C' to terminate the application...");
            while(true)
            {
                if (Console.ReadKey(true).KeyChar.ToString().ToUpperInvariant() == "C")
                {
                    Console.WriteLine($"[{Name}] 'C' pressed. Terminating application...");
                    _cancellationTokenSource.Cancel();
                    break;
                }
            }
            ExitSuccess();
            return;
        }
    }
}
