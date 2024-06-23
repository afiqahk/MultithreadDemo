using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultithreadConsoleApp.Classes
{
    internal abstract class ThreadManaged
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
