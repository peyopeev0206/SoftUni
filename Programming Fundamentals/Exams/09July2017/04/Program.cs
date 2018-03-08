using System;
using System.Linq;
using System.Collections.Generic;
namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var logInput = Console.ReadLine()
                                  .Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            var pokemonEvolution = new Dictionary<string, List<string>>();

            while (logInput[0] != "wubbalubbadubdub")
            {
                string pokemonName = logInput[0];
                if (logInput.Count > 1)
                {
                    string evolutionType = logInput[1];
                    int evolutionIndex = int.Parse(logInput[2]);

                    if (!pokemonEvolution.ContainsKey(pokemonName))
                    {
                        pokemonEvolution.Add(pokemonName, new List<string>());
                    }
                    string pointsEvolutionType = logInput[1] + " <-> " + int.Parse(logInput[2]);
                    pokemonEvolution[pokemonName].Add(pointsEvolutionType);
                }else
                {
                    if (pokemonEvolution.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evoluton in pokemonEvolution[pokemonName])
                        {
                            Console.WriteLine($"{evoluton}");
                        }
                    }
                    
                }

                logInput = Console.ReadLine()
                              .Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            .ToList();
            }

            foreach (var pokemon in pokemonEvolution)
            {
                Console.WriteLine("# {0}", pokemon.Key);

                foreach (string evoluton in pokemon.Value.OrderByDescending(x => int.Parse(x.Split(new[] { " <-> " }, StringSplitOptions.None).Skip(1).First())))
                {
                    Console.WriteLine($"{evoluton}");
                }
            }

        }
    }
}
