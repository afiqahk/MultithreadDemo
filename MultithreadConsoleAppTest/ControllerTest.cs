using MultithreadConsoleApp;
using MultithreadConsoleApp.Interfaces;

namespace MultithreadConsoleAppTest
{
    public class ControllerTest
    {
        [Fact]
        public void Test_IsNot_ICancellable()
        {
            var cts = new CancellationTokenSource();
            var instance = new Controller(cts, Utils.LogExitStatus);

            Assert.False(instance is ICancellable);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_OnStarted(bool setNull)
        {
            var cts = new CancellationTokenSource();
            var instance = new Controller(cts, Utils.LogExitStatus);
            var res = setNull ? instance.OnStarted(null) : instance.OnStarted(cts.Token);
            Assert.True(res);
        }
    }
}