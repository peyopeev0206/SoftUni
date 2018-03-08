using System;
using System.Linq;
namespace StringsAndTextProcessing
{
    public class UnicodeCharacters
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            var chars = input
                .Select(c => (int) c)
                .Select(c => $@"\u{c:x4}");


            System.Console.WriteLine(string.Concat(chars));
        }
    }
}