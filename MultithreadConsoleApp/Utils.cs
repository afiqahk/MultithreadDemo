using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal static class Utils
    {
        internal delegate void ExitCallback(string callerName, bool exitStatus, string? message);
        internal static void LogExitStatus(string callerName, bool exitStatus, string? message)
        {
            var logOutput = $"[{callerName}] Thread exited with status '{exitStatus}'";
            if (message is not null)
            {
                logOutput = logOutput + $": {message}";
            }
            Console.WriteLine(logOutput);
        }
    }
}
