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
        private readonly string _name = "controller";

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
            Console.WriteLine($"[{_name}] Thread started...");
            Console.WriteLine($"[{_name}] Press 'C' to terminate the application...");
            while(true)
            {
                if (Console.ReadKey(true).KeyChar.ToString().ToUpperInvariant() == "C")
                {
                    Console.WriteLine($"[{_name}] 'C' pressed. Terminating application...");
                    _cancellationTokenSource.Cancel();
                    break;
                }
            }
            _exitCallback(_name, true, null);
            return;
        }
    }
}
