using System;
using System.Linq;
using System.Collections.Generic;
namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {

            //var squadList = new List<Squad>();
            //string input = string.Empty;

            //while ((input = Console.ReadLine()) != "Blaze it!")
            //{
            //    string[] fireCreaturs = input
            //        .Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    string creatur = fireCreaturs[0];
            //    string squadMate = fireCreaturs[1];

            //    if (creatur != squadMate)
            //    {
            //        if (!squadList.Any(x => x.creature == creatur))
            //        {
            //            var newSquad = new Squad
            //            {
            //                creature = creatur,
            //                squadMate = new List<string>()

            //            };
            //            squadList.Add(newSquad);
            //        }else
            //        {
            //            var foundSquad = squadList.Find(x=> x.creature==creatur);
            //            if(!foundSquad.squadMate.Any(x=>x == squadMate))
            //            {
            //                foundSquad.squadMate.Add(squadMate);
            //                foundSquad.squadMate.Remove(creatur);
            //            }
            //        }
            //    }
            //}

            //foreach (var sq in squadList)
            //{
            //    var createrName = sq.creature;
            //    var foundSmt = squadList.Find(e => e.creature == sq.creature);
            //    if (sq.squadMate.Any(s => s == foundSmt.creature))
            //    {
            //        //foundSmt.squadMate = new List<string>();
            //        //sq.squadMate = new List<string>();
            //        sq.squadMate.Remove(foundSmt.squadMate.ToString());
            //        foundSmt.squadMate.Any(x=>x==sq.creature);

            //    }
            //}

            //foreach (var sq in squadList.OrderByDescending(x=>x.squadMate.Count()))
            //{
            //    Console.WriteLine("{0} : {1}", sq.creature, sq.squadMate.Count());
            //}



            string input = string.Empty;
            var squad = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "Blaze it!")
            {
                string[] fireCreaturs = input
                    .Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string creatur = fireCreaturs[0];
                string squadMate = fireCreaturs[1];
                if (creatur != squadMate)
                {
                    if (!squad.Values.Any(x => x.Any(b=> b== creatur)))
                    {
                        if (!squad.ContainsKey(creatur))
                        {
                            squad.Add(creatur, new List<string>());

                        }
                        if (!squad[creatur].Contains(squadMate) && !squad.ContainsKey(squadMate))
                        {
                            squad[creatur].Add(squadMate);
                        }
                    }else
                    {
                        var fountCreatur = squad.First(x => x.Value.Find(c => c==creatur) == creatur);
                        fountCreatur.Value.Remove(creatur);
                        if (!squad.ContainsKey(creatur))
                        {
                            squad.Add(creatur, new List<string>());

                        }
                        if (!squad[creatur].Contains(squadMate) && !squad.ContainsKey(squadMate))
                        {
                            squad[creatur].Add(squadMate);
                        }
                    }
                }
            }

            foreach (var sq in squad.OrderByDescending(x=>x.Value.Count()))
            {
                Console.WriteLine("{0} : {1}", sq.Key, sq.Value.Count());
            }
        }

        class Squad
        {
            public string creature { get; set; }
            public List<string> squadMate { get; set; }
        }
    }
}
