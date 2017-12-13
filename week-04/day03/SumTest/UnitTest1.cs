using NUnit.Framework;
using System.Collections.Generic;

using Sum;


namespace SumTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMultipleElements()
        {           
            var sum = new ListSum();
            List<int> testList = new List<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(2);
            testList.Add(1);
            testList.Add(1);
            Assert.AreEqual(7,sum.SumListElements(testList));
        }

        [Test]
        public void TestEmptyArray()
        {
            var sum = new ListSum();
            List<int> testList = new List<int>();
            Assert.AreEqual(0, sum.SumListElements(testList));
        }

        [Test]
        public void TestOneElementArray()
        {
            var sum = new ListSum();
            List<int> testList = new List<int>();
            testList.Add(1);
            Assert.AreEqual(1, sum.SumListElements(testList));
        }
    }
}
