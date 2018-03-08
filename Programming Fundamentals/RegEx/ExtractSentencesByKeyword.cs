using System;
using System.Text.RegularExpressions;
namespace RegEx
{
    public class ExtractSentencesByKeyword
    {
        public static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = string.Format(@"\b[^?.!]*\b{0}\b[^?.!]*", keyWord);
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(text);
            foreach (Match i in matches)
            {
                Console.WriteLine(i);
            }
        }
    }
}