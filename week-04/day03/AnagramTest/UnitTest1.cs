using NUnit.Framework;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1([Values("cica", "kutyus", "kecske")]string inputString1, 
                                [Values("acic", "tykuus", "kecskeh")]string inputString2)
        {
            var angr = new Angram();
            Assert.True(angr.AngramChecker(inputString1, inputString2));
        }
    }
}
