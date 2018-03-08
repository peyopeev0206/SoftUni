using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, int>();
            var hatCount = new Dictionary<string, int>();

            string line;
            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = line.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = tokens[0];
                string dwarfHatColer = tokens[1];
                int dwarfPhisics = int.Parse(tokens[2]);

                if (!hatCount.ContainsKey(dwarfHatColer))
                {
                    hatCount.Add(dwarfHatColer,1);
                }else
                {
                    hatCount[dwarfHatColer]++;
                }

                string currentDwarfID = $"{dwarfName} <:> {dwarfHatColer}";

                if (!dwarfs.ContainsKey(currentDwarfID))
                {
                    dwarfs.Add(currentDwarfID, dwarfPhisics);
                }else
                {
                    int oldValue = dwarfs[currentDwarfID];
                    if (dwarfPhisics>oldValue)
                    {
                        dwarfs[currentDwarfID] = dwarfPhisics;
                    }
                }
            }

            Dictionary<string,int> sortedDwarfs = dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x=>hatCount[x.Key.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries)[1]])
                .ToDictionary(x =>x.Key, x=>x.Value);

            foreach (var dwarf in sortedDwarfs)
            {
                string dwarfID = dwarf.Key;
                string[] dwarfIDTokens = dwarfID.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = dwarfIDTokens[0];
                string dwarfHatColor = dwarfIDTokens[1];

                int phisics = dwarf.Value;

                Console.WriteLine($"({dwarfHatColor}) {dwarfName} <-> {phisics}");
            }

        }
    }
}
