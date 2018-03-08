using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] placeholder = Console.ReadLine()
                                          .Split(new char[]{'{','}'},StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

            Regex regex = new Regex(@"([a-zA-Z]+)(?<placeholder>.+)\1");
            var match = regex.Matches(encodedText);

            int indexPlaceholder = 0;

            foreach (Match matches in match)
            {
                if (true)
                {
                    if (indexPlaceholder >= placeholder.Length) break;

                    encodedText = ReplacePlaceholder(encodedText, matches.Groups["placeholder"].Value,
                                                     placeholder[indexPlaceholder++]);
                }
            }

            Console.WriteLine(encodedText);

        }

        static string ReplacePlaceholder(string text, string oldValue, string newValue)
        {
            string substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);

            string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

            return substringWithNewValue + text.Substring(substringWithOldValue.Length);
        }
    }
}
