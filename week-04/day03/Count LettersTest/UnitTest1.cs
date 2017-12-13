using NUnit.Framework;
using Count_Letters;
using System.Collections.Generic;

namespace Count_LettersTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1([Values ("cica")]string word)
        {
            var cl = new LetterCount();
            var dict = new Dictionary<char, int>();
            dict.Add('a', 1);
            dict.Add('c', 2);
            dict.Add('i', 1);
            

            Assert.Equals(dict, cl.LetterCounter(word));
        }
    }
}
