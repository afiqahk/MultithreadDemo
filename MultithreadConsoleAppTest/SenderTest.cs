using MultithreadConsoleApp;
using MultithreadConsoleApp.Interfaces;

namespace MultithreadConsoleAppTest
{
    public class SenderTest
    {
        [Fact]
        public void Test_Is_ICancellable()
        {
            var instance = new Sender(Utils.LogExitStatus);

            Assert.True(instance is ICancellable);
        }
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void Test_OnStarted(bool setNull, bool expected)
        {
            var cts = new CancellationTokenSource();
            var instance = new Sender(Utils.LogExitStatus);
            var res = setNull ? instance.OnStarted(null) : instance.OnStarted(cts.Token);
            Assert.True(res == expected);
        }
        [Fact]
        public void Test_OnStarted_Exception()
        {
            var cts = new CancellationTokenSource();
            var instance = new Sender(Utils.LogExitStatus);
            Assert.Throws<InvalidCastException>(() => instance.OnStarted(cts));
        }
    }
}