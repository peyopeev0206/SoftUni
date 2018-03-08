using System;
using System.Text.RegularExpressions;
namespace RegEx
{
    public class ExtractEmails
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(text);
            foreach (Match i in matches)
            {
                Console.WriteLine(i);
            }
        }
    }
}