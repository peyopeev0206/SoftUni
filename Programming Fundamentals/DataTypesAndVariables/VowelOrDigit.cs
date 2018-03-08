using System.Text.RegularExpressions;

namespace DataTypesAndVariables
{
    public class VowelOrDigit
    {
        public static void Main(string[] args)
        {
            string input = System.Console.ReadLine().ToLower();

            if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
            {
                System.Console.WriteLine("vowel");
            }else if(Regex.IsMatch(input, @"^\d+$"))
            {
                System.Console.WriteLine("digit");
            }else
            {
                System.Console.WriteLine("other");
            }
        }
    }
}