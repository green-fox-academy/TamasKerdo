using finalWeek_7;
using System.Collections.Generic;
using Xunit;

namespace finalWeek_7_XUnitTest
{
    public class LetterPositionFinderTester
    {
        [Fact]
        public void Test1()
        {
            char letter = 'a';
            string word = "almafa";
            var letterPositionFinder = new LetterPositionFinder();
            var foundLetterPOsitions = new List<int>() {0,3,5};

            Assert.Equal(foundLetterPOsitions, letterPositionFinder.LetterFinder(word, letter));
        }

        [Fact]
        public void Test2()
        {
            char letter = 'a';
            string word = "aaaaaa";
            var letterPositionFinder = new LetterPositionFinder();
            var foundLetterPOsitions = new List<int>() { 0, 1, 2, 3, 4, 5 };

            Assert.Equal(foundLetterPOsitions, letterPositionFinder.LetterFinder(word, letter));
        }
    }
}
