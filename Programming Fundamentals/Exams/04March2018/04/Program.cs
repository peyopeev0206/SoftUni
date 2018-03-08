using System;
using System.Collections.Generic;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;

            var forceDict = new Dictionary<string, List<string>>();

            while ((line = Console.ReadLine()) != "Lumpawaroo")
            {
                if (line.Contains("|"))
                {
                    string[] forceInformation = line.Split(" | ");
                    string forceSide = forceInformation[0];
                    string forceUser = forceInformation[1];

                    if (!forceDict.ContainsKey(forceSide))
                    {
                        forceDict.Add(forceSide, new List<string>());
                    }

                    if (!forceDict[forceSide].Contains(forceUser))
                    {
                        forceDict[forceSide].Add(forceUser);
                    }
                }else
                {

                    string[] forceInformation = line.Split(" -> ");
                    string forceSide = forceInformation[1];
                    string forceUser = forceInformation[0];

                    foreach (KeyValuePair<string, List<string>> forces in forceDict)
                    {
                        if (forces.Value.Contains(forceUser))
                        {
                            forceDict[forces.Key].Remove(forceUser);
                            //forceDict[forceSide].Add(forceUser);

                            if (!forceDict.ContainsKey(forceSide))
                            {
                                forceDict.Add(forceSide, new List<string>());
                            }

                            if (!forceDict[forceSide].Contains(forceUser))
                            {
                                forceDict[forceSide].Add(forceUser);
                            }
                            //Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                            break;
                        }
                    }
                    if (!forceDict.ContainsKey(forceSide))
                    {
                        forceDict.Add(forceSide, new List<string>());
                    }

                    if (!forceDict[forceSide].Contains(forceUser))
                    {
                        forceDict[forceSide].Add(forceUser);
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                   

                }
            }

            foreach (var side in forceDict.OrderByDescending(x=>x.Value.Count()).ThenBy(x=>x.Key))
            {
                if (side.Value.Count() > 0)
                {
                    Console.WriteLine("Side: {0}, Members: {1}", side.Key, side.Value.Count());

                    side.Value.Sort();
                    foreach (string users in side.Value)
                    {
                        Console.WriteLine($"! {users}");
                    }
                }

            }
        }
    }
}

