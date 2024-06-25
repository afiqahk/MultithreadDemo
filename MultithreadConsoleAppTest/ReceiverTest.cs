using MultithreadConsoleApp;
using MultithreadConsoleApp.Classes;
using System.Collections.Concurrent;

namespace MultithreadConsoleAppTest
{
    public class ReceiverTest : ThreadManagedICancellableTest
    {
        public override ThreadManaged CreateInstance()
        {
            return new Receiver(Utils.LogExitStatus);
        }
        public void Test_GetItem()
        {
            var instance = new Receiver(Utils.LogExitStatus);
            ConcurrentQueue<int> queue = new();
            instance.ReceiveData(queue, Utils.GetInt);
            var success = queue.TryDequeue(out var item);
            Assert.True(success);
        }
    }
}
