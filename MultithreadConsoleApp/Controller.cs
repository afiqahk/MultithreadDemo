﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadConsoleApp
{
    internal static class Controller
    {
        internal static void RunController()
        {
            Console.WriteLine("Controller started...");
            Thread.Sleep(1000);
            Console.WriteLine("Controller exiting...");
        }
    }
}
