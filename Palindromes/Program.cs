using System;
using System.Text.RegularExpressions;

namespace Palindromes
{
    class Program
    {
        /// <summary>
        /// Determines if the given value is a palindrome.
        /// </summary>
        /// <returns><c>true</c>, if value is a palindrome, <c>false</c> otherwise.</returns>
        /// <param name="value">String to evaluate</param>
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;

            while (true)
            {
                if (min > max)
                    return true;

                char a = value[min];
                char b = value[max];

                if (char.ToLower(a) != char.ToLower(b))
                    return false;

                min++;
                max--;
            }
        }

        /// <summary>
        /// Determines if a sentence is a palindrome.  Addition from CodeProject.
        /// </summary>
        /// <returns><c>true</c>, if sentence is apalindrome, <c>false</c> otherwise.</returns>
        /// <param name="sentence">A sentence to evaluate</param>
        public static bool IsSentencePalindrome(string sentence)
        {
            // determine the forward version with only characters
            string forward = string.Empty;

            foreach (char sentenceCharacter in sentence.ToLower())
            {
                if (char.IsLetter(sentenceCharacter))
                    forward += sentenceCharacter;
            }

            char[] temp = forward.ToCharArray();
            Array.Reverse(temp);
            string reverse = new string(temp);
            return forward == reverse;
        }

        /// <summary>
        /// Removes the special characters from the given string.
        /// </summary>
        /// <returns>The string without the special characters.</returns>
        /// <param name="value">A valid string.</param>
        public static string RemoveSpecialCharacters(string value)
        {
            Regex regex = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", 
                                    RegexOptions.IgnoreCase | 
                                    RegexOptions.CultureInvariant | 
                                    RegexOptions.Compiled);
            return regex.Replace(value, String.Empty);
        }

        static void Main(string[] args)
        {
            string[] arrayOfWords =
            {
                "civic",
                "racecar",
                "mike",
                "solos"
            };

            string[] arrayOfSentences =
            {
                "Noel sees ?+= Leon.",
                "This will not work"
            };

            // loop through the array and determine which words are palindromes
            foreach (var value in arrayOfWords)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }

            // loop through the array and determine which sentences are palindromes
            foreach (var value in arrayOfSentences)
            {
                Console.WriteLine("{0} = {1}", value, IsSentencePalindrome(value));
            }

            // loop through the array of sentences and remove the special characters
            foreach (var value in arrayOfSentences)
            {
                Console.WriteLine("{0} = {1}", value, RemoveSpecialCharacters(value));
            }

            Console.WriteLine();
            Console.WriteLine("<<Processing Complete>>");
        }
    }
}
