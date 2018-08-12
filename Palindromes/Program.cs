using System;

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

        static void Main(string[] args)
        {
            string[] array =
            {
                "civic",
                "racecar",
                "mike",
                "solos"
            };

            // loop through the array and determine which words are palindromes
            foreach (var value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
            Console.WriteLine("<<Processing Complete>>");
        }
    }
}
