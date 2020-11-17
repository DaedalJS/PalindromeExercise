using System;
using Xunit;


namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tonberry", false)]
        public void IsAPalTest(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            //act
            var actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
            
        }
    }
}
