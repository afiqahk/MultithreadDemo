using MultithreadConsoleApp;
using MultithreadConsoleApp.Classes;
using MultithreadConsoleApp.Interfaces;

namespace MultithreadConsoleAppTest
{
    public abstract class ThreadManagedICancellableTest
    {
        public abstract ThreadManaged CreateInstance();

        [Fact]
        public void Test_Is_ICancellable()
        {
            var instance = CreateInstance();

            Assert.True(instance is ICancellable);
        }
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void Test_OnStarted(bool setNull, bool expected)
        {
            var cts = new CancellationTokenSource();
            var instance = CreateInstance();
            var res = setNull ? instance.OnStarted(null) : instance.OnStarted(cts.Token);
            Assert.True(res == expected);
        }
        [Fact]
        public void Test_OnStarted_Exception()
        {
            var cts = new CancellationTokenSource();
            var instance = CreateInstance();
            Assert.Throws<InvalidCastException>(() => instance.OnStarted(cts));
        }
    }
}