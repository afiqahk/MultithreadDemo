using MultithreadConsoleApp;
using MultithreadConsoleApp.Classes;

namespace MultithreadConsoleAppTest
{
    public class ReceiverTest : ThreadManagedICancellableTest
    {
        public override ThreadManaged CreateInstance()
        {
            return new Receiver(Utils.LogExitStatus);
        }
    }
}
