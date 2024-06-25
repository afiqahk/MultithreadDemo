using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    public static class Utils
    {
        public delegate void ExitCallback(string callerName, bool exitStatus, string? message);
        public static void LogExitStatus(string callerName, bool exitStatus, string? message)
        {
            var logOutput = $"[{callerName}] Thread exited with status '{exitStatus}'";
            if (message is not null)
            {
                logOutput = logOutput + $": {message}";
            }
            Console.WriteLine(logOutput);
        }
        public delegate T ReceiverDelegate<T>(); 
        public static int GetInt()
        {
            int i = 0;
            return i++;
        }
    }
}
