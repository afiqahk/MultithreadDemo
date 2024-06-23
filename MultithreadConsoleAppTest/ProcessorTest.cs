using MultithreadConsoleApp;
using MultithreadConsoleApp.Classes;

namespace MultithreadConsoleAppTest
{
    public class ProcessorTest : ThreadManagedICancellableTest
    {
        public override ThreadManaged CreateInstance()
        {
            return new Processor(Utils.LogExitStatus);
        }
    }
}
