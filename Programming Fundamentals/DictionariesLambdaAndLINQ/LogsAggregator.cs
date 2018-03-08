using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesLambdaAndLINQ
{
    public class LogsAggregator
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            var logsInput = new SortedDictionary<string,SortedDictionary<string,int>>();

            for (int i = 0; i < n; i++)
            {
                string[] usersInfo = Console.ReadLine()
                                .Split()
                                .ToArray();

                string ip = usersInfo[0];
                string username = usersInfo[1];
                int duration =int.Parse( usersInfo[2]);

                if (!logsInput.ContainsKey(username))
                {
                    logsInput.Add(username,new SortedDictionary<string,int>());
                }

                if (!logsInput[username].ContainsKey(ip))
                {
                    logsInput[username].Add(ip,duration);
                }else
                {
                    logsInput[username][ip]+=duration;    
                }
            }

            foreach (var users in logsInput)
            {
                System.Console.WriteLine("{0}: {1} [{2}]",
                        users.Key,logsInput[users.Key].Values.Sum(),string.Join(", ",users.Value.Keys.ToList()));
            }
        }
    }
}