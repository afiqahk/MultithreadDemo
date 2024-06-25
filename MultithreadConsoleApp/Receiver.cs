using MultithreadConsoleApp.Classes;
using MultithreadConsoleApp.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    public class Receiver : ThreadManaged, ICancellable
    {
        public CancellationToken Token { get; set; }
        public Receiver(
            Utils.ExitCallback exitCallback
            ) : base("receiver", exitCallback)
        { }
        public void Run(object? obj)
        {
            if (!OnStarted(obj)) return;
            while (!Token.IsCancellationRequested)
            {
            }
            ExitSuccess();
            return;
        }
        public void ReceiveData<T>(ConcurrentQueue<T> queue, Utils.ReceiverDelegate<T> receiver)
        {
            var item = receiver();
            queue.Enqueue(item);
        }
    }
}
