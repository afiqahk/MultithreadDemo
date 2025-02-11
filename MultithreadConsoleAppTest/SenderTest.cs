﻿using MultithreadConsoleApp;
using MultithreadConsoleApp.Classes;

namespace MultithreadConsoleAppTest
{
    public class SenderTest : ThreadManagedICancellableTest
    {
        public override ThreadManaged CreateInstance()
        {
            return new Sender(Utils.LogExitStatus);
        }
    }
}
