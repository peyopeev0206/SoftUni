using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _Snowflake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firsthAndLastRowPattern = @"^([^A-Za-z\d]+)";
            string secondAndFourthRowPattern = @"^([\d_]+)";
            string thirdRowPattern = @"^((?:[^A-Za-z\d]+)(?:[\d_]+)(?<core>[a-zA-Z]+)(?:[\d_]+)(?:[^A-Za-z\d]+))";
          

            List<string> inputs = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                string lineInput = Console.ReadLine();
                
                inputs.Add(lineInput);

            }

          
            if (Regex.IsMatch(inputs[0] , firsthAndLastRowPattern) &&
            Regex.IsMatch(inputs[1] , secondAndFourthRowPattern) &&
            Regex.IsMatch(inputs[2] , thirdRowPattern) &&
            Regex.IsMatch(inputs[3] , secondAndFourthRowPattern) &&
            Regex.IsMatch(inputs[4] , firsthAndLastRowPattern) )
            {
                Match match = Regex.Match(inputs[2] , thirdRowPattern);
                int coreLe = match.Groups["core"].Value.Length;
                Console.WriteLine("Valid");
                Console.WriteLine(coreLe);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}