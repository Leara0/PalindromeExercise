using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class PalindromeTest
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("bunny", false)]
        [InlineData("quit", false)]
        [InlineData("kayak", true)]
        [InlineData("rotator", true)]
        [InlineData("peep", true)]
        public void TestIsAPalindrome(string word, bool expected)
        {
            var wordSmith = new WordSmith();
            var actual = WordSmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
