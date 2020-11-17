using System;

namespace PalindromeExercise
{
    public class WordSmith
    {
        
        public bool IsAPalindrome(string strang)
        {
            char[] brokenStrang = strang.ToCharArray();
            string backwards = null;
            for (int i = brokenStrang.Length - 1; i > -1; i--)
            {
                backwards += brokenStrang[i];
            }
            return backwards == strang ? true : false;
        }
    }
}
