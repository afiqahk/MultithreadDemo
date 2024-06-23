using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal class Controller
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        private readonly Utils.ExitCallback _exitCallback;

        public Controller(
            CancellationTokenSource cancellationTokenSource,
            Utils.ExitCallback exitCallback
            )
        {
            _cancellationTokenSource = cancellationTokenSource;
            _exitCallback = exitCallback;
        }
        internal void RunController()
        {
            Console.WriteLine("[controller] Thread started...");
            Console.WriteLine("[controller] Press 'C' to terminate the application...");
            while(true)
            {
                if (Console.ReadKey(true).KeyChar.ToString().ToUpperInvariant() == "C")
                {
                    Console.WriteLine("[controller] 'C' pressed. Terminating application...");
                    _cancellationTokenSource.Cancel();
                    break;
                }
            }
            _exitCallback("controller", true, null);
            return;
        }
    }
}
