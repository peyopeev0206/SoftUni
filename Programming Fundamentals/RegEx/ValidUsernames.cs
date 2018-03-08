using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class ValidUsernames
    {
        public static void Main(string[] args)
        {
            string[] usernameInput = Console.ReadLine()
            .Split("\\ /()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();


            string pattern = @"^[a-zA-Z][a-zA-Z\d_]{2,24}$";

            List<string> validUsernames = new List<string>();

            foreach (string valudUsername in usernameInput)
            {
                var match = Regex.Match(valudUsername, pattern);

                if (match.Success)
                {
                    validUsernames.Add(valudUsername);
                }
            }

            int maxLength = 0;
            int bestIndex = 0;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                int currentUsernameLength = validUsernames[i].Length;
                int nextUsernameLength = validUsernames[i + 1].Length;

                if (currentUsernameLength + nextUsernameLength > maxLength)
                {
                    maxLength = currentUsernameLength + nextUsernameLength;
                    bestIndex = i;
                }
            }

            Console.WriteLine(validUsernames[bestIndex]);
            Console.WriteLine(validUsernames[bestIndex + 1]);
        }
    }
}