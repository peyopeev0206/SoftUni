using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            string line = Console.ReadLine().ToUpper();

            var matches = regex.Matches(line);

            StringBuilder result = new StringBuilder();
            List<char> unique = new List<char>();
            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value;
                int repeat = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < repeat; i++)
                {
                    result.Append(text);

                }
                if (repeat != 0)
                {
                    unique.AddRange(text);
                }
            }
            Console.WriteLine("Unique symbols used: {0}",unique.Distinct().Count());
            Console.WriteLine(result);
        }
    }
}
