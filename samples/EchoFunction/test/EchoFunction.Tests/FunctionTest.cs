using Xunit;
using Amazon.Lambda.TestUtilities;

namespace EchoFunction.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {
            var function = new Function();
            var context = new TestLambdaContext();
            const string request = "hello world";
            var response = function.FunctionHandler( request, context);

            Assert.Equal(request, response);
        }
    }
}
