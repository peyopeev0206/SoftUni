    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    namespace _03
    {
        class Program
        {
            static void Main(string[] args)
            {            
                int messages = int.Parse(Console.ReadLine());
                string pattern = @"(?i)(s|t|a|r)";
                var attacketList = new List<string>();
                var destructionList = new List<string>();
                var encodedMsg = new List<string>();
                for (int i = 0; i < messages; i++)
                {
                    string input = Console.ReadLine();

                    int br = 0;
                    foreach (Match m in Regex.Matches(input, pattern))
                    {
                        br++;
                    }

                    char[] result = input.ToCharArray();

                    for (int q = 0; q < result.Length; q++)
                    {
                        int asciiValue = (int)result[q];
                        result[q] = (char)((int)result[q] - br);
                    }

                    encodedMsg.Add(string.Join(string.Empty,result).ToString());
                }

                for (int i = 0; i < messages; i++)
                {
                    

                    if (Regex.IsMatch(encodedMsg[i],@"\@(?<planetName>[\w]+):(?<population>\d)+!(?<aOrd>A|D)!->\d+"))
                    {
                        encodedMsg[i] = encodedMsg[i].Substring(encodedMsg[i].IndexOf('@') + 1);
                        string[] readableEncodedMsg = encodedMsg[i]
                        .Split(new char[] {'-', '!', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                        var planetName = Regex.Replace(readableEncodedMsg[0], @"[\d]+", string.Empty);
                        var planetPopulation = readableEncodedMsg[1];
                        var attOrDess = readableEncodedMsg[2].ToUpper();
                        var solderCount = readableEncodedMsg[3];

                        if (attOrDess == "A")
                        {
                            attacketList.Add(planetName);
                        }
                        else if(attOrDess == "D")
                        {
                            destructionList.Add(planetName);
                        }
                    }

                }

                Console.WriteLine("Attacked planets: {0}",attacketList.Count);
                attacketList.Sort();
                foreach (var a in attacketList)
                {
                    Console.WriteLine("-> {0}",a);
                }

                Console.WriteLine("Destroyed planets: {0}", destructionList.Count);
                destructionList.Sort();
                foreach (var d in destructionList)
                {
                    Console.WriteLine("-> {0}", d);
                }
            }
        }
    }
