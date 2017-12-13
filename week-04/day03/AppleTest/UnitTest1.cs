using System;
using Apple;
using NUnit.Framework;

namespace AppleTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var ap = new Program();
            string Variable = ap.ReturnApple();

            Assert.AreEqual("Apple", Variable);
        }
    }
}
