using System;
using System.Collections.Generic;
using System.Linq;
namespace DictionariesLambdaAndLINQ {
    public class Phonebook {
        public static void Main (string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string[] command = Console.ReadLine()
                            .Split()
                            .ToArray();
            
            while (command[0] != "END")
            {
    
                if (command[0] == "S")
                {
                    if (!phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine("Contact {0} does not exist.", command[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                    }
                }
                else
                {
                    phonebook[command[1]] = command[2];
                }
    
                command = Console.ReadLine()
                            .Split()
                            .ToArray();
            }   
        }
    }
}