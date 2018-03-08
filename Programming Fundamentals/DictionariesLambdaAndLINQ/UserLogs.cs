using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesLambdaAndLINQ
{
    public class UserLogs
    {
        public static void Main(string[] args)
        {
            var userLogsInput = new SortedDictionary<string,Dictionary<string,int>>();
            string[] logInput = Console.ReadLine()
                                .Split(new char[] {'=',' '}, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            

            while (logInput[0] != "end")
            {
                string username = logInput[5];
                string ip = logInput[1];
                int messageCounter = 1;

                if (!userLogsInput.ContainsKey(username))
                {
                    userLogsInput.Add(username,new Dictionary<string,int>());
                }

                if (!userLogsInput[username].ContainsKey(ip))
                {
                    userLogsInput[username].Add(ip,messageCounter);
                }else
                {
                    userLogsInput[username][ip]++;    
                }

                logInput = Console.ReadLine()
                                .Split(new char[] {'=',' '}, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            }

            foreach (var users in userLogsInput)
            {
                System.Console.WriteLine("{0}: ",users.Key);

                foreach (var userLog in users.Value)
                {
                    if (userLog.Key != users.Value.Keys.Last())
                    {
                        Console.Write($"{userLog.Key} => {userLog.Value}, ");   
                    }else
                    {
                        Console.WriteLine($"{userLog.Key} => {userLog.Value}. ");   
                    }
                }
            }
        }
    }
}