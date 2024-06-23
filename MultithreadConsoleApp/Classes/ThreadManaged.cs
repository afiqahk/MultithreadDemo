using MultithreadConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultithreadConsoleApp.Classes
{
    public abstract class ThreadManaged
    {
        public string Name { get; }
        public Utils.ExitCallback ExitCallback { get; }
        public ThreadManaged(
            string name,
            Utils.ExitCallback exitCallback
        )
        {
            Name = name;
            ExitCallback = exitCallback;
        }
        public bool OnStarted(object? obj)
        {
            Console.WriteLine($"[{Name}] Thread started...");
            if (this is ICancellable cancellableObj)
            {
                if (obj is null)
                {
                    ExitFail("ct is null");
                    return false;
                }
                cancellableObj.Token = (CancellationToken)obj;
            }
            return true;
        }
        public void ExitFail(string message)
        {
            ExitCallback(Name, false, message);
        }
        public void ExitSuccess()
        {
            ExitCallback(Name, true, null);
        }
    }
}
