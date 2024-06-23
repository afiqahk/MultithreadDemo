using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp.Interfaces
{
    public interface ICancellable
    {
        public CancellationToken Token { get; set; }
        void Run(object? obj);
    }
}
