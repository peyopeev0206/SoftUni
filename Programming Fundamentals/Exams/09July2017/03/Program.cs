using System;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string didimonPattern = @"[^A-Za-z-]+";
            string bojomonPattern = @"[A-Za-z]+-[A-Za-z]+";

            while (true)
            {
                if (!Regex.IsMatch(inputText,didimonPattern))
                {
                    return;
                }else
                {
                    var current = Regex.Match(inputText, didimonPattern);
                    inputText = inputText.Substring(current.Index + current.Length);
                    Console.WriteLine(current.ToString());
                }

                if (!Regex.IsMatch(inputText, bojomonPattern))
                {
                    return;
                }
                else
                {
                    var current = Regex.Match(inputText, bojomonPattern);
                    inputText = inputText.Substring(current.Index + current.Length);
                    Console.WriteLine(current.ToString());
                }
            }
        }
    }
}
