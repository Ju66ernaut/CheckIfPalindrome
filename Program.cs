using System;

namespace CheckIfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string input = Console.ReadLine();

                char[] inputArray = input.ToCharArray();

                string output = string.Empty;
                for (int i = inputArray.Length - 1; i > -1; i--)
                {
                    output += inputArray[i];
                }

                var message = input == output ? "This is a palindrome!" : "This is NOT a palindrome";
                Console.WriteLine(message);

            } while (true);
        }
    }
}
