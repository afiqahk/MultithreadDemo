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

        public Controller(
            CancellationTokenSource cancellationTokenSource
            )
        {
            _cancellationTokenSource = cancellationTokenSource;
        }
        internal void RunController()
        {
            Console.WriteLine("[controller] Thread started...");
            Console.WriteLine("[controller] Press 'C' to terminate the application...");
            while(true)
            {
                if (Console.ReadKey(true).KeyChar.ToString().ToUpperInvariant() == "C")
                {
                    _cancellationTokenSource.Cancel();
                    break;
                }
            }
            Console.WriteLine("[controller] Thread exiting...");
        }
    }
}
