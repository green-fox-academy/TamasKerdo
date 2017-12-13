using NUnit.Framework;
using Fibonacci;

namespace FibonacciTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var fi = new Fibo();
            int input = 5;
            int output = fi.FiboCounter(input);

            Assert.AreEqual(8,output);
        }
    }
}
