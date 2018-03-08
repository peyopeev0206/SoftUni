using System;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @"^([^\s_]{3}\.)*[^\s_]{3}$";

            while ((input = Console.ReadLine()) != "ReadMe")
            {

                var match = Regex.Match(input, pattern);

                if (match.Success && IsPalindrome(input))
                {
                    Console.WriteLine("YES");
                }else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        private static bool IsPalindrome(string input)
        {
            bool result = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}