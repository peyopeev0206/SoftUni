using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesLambdaAndLINQ
{
    public class PopulationCounter
    {
        public static void Main(string[] args)
        {
            var populationInput = new SortedDictionary<string,Dictionary<string,long>>();

            string[] populationData = Console.ReadLine().
                                        Split('|').
                                        ToArray();
            while (populationData[0] != "report")
            {                
                string city = populationData[0];
                string country = populationData[1];
                long population = long.Parse(populationData[2]);

                if (!populationInput.ContainsKey(country))
                {
                    populationInput.Add(country, new Dictionary<string,long>());
                }

                if (!populationInput[country].ContainsKey(city))
                {
                    populationInput[country].Add(city,population);
                }else
                {
                    populationInput[country][city]+=population;    
                }

                populationData = Console.ReadLine().
                                        Split('|').
                                        ToArray();
            }

                foreach (var state in populationInput.OrderByDescending(x=>x.Value.Sum(y=>y.Value)))
                {
                    List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                    Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");
        
                    Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x=>x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
                }

        }
    }
}