using System;

namespace PalindromeExercise;

public class WordSmith
{
    public static bool IsAPalindrome(string word)
    {
        var charArray = word.ToCharArray();
        for (int i = 0; i < word.Length / 2; i++)
        {
            var firstChar = word[i];
            charArray[i] = word[word.Length - 1 - i];
            charArray[word.Length - 1 - i] = firstChar;
        }

        var newWord = new string(charArray);
        return (newWord == word);
    }
}