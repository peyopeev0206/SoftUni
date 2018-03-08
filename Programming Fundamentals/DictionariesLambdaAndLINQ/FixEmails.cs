using System;
using System.Collections.Generic;
using System.Linq;
namespace DictionariesLambdaAndLINQ
{
    public class FixEmails
    {
        public static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            string commandInput = Console.ReadLine();

            while (commandInput != "stop")
            {
                string emailInput = Console.ReadLine(); 
                string[] fakeEmails = emailInput
                            .Split('.')
                            .ToArray(); 
                if (fakeEmails[1].ToLower()!="us" && fakeEmails[1].ToLower()!="uk")
                {
                    emails[commandInput] = emailInput;
                }
                commandInput = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                System.Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
        }
    }
}