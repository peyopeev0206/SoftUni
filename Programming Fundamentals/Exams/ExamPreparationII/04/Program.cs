using System;
using System.Linq;
using System.Collections.Generic;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
                                   

            var eventsIdToName = new Dictionary<int, string>();
            var eventsParticipants = new Dictionary<int, List<string>>();

            while (true)
            {

                var lineInput = Console.ReadLine();
                if (lineInput == "Time for Code")
                {
                    break;
                }

                var arrayInput = lineInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .ToArray();

                int eventID = 0;
                if (!int.TryParse(arrayInput[0],out eventID))
                {
                    continue;
                }

                string eventName = arrayInput[1];
                if (!eventName.StartsWith("#"))
                {
                    continue;
                }
                eventName=eventName.Trim('#');


                var wrongInput = false;
                var participants = new List<string>();
                for (int i = 2; i < arrayInput.Length; i++)
                {
                    if (!arrayInput[i].StartsWith("@"))
                    {
                        wrongInput = true;
                        break;
                    }
                    participants.Add(arrayInput[i]);
                }

                if (wrongInput)
                {
                    continue;
                }

                if (eventsIdToName.ContainsKey(eventID))
                {
                    var existingEventName = eventsIdToName[eventID];
                    if (existingEventName == eventName)
                    {
                        eventsParticipants[eventID].AddRange(participants);
                    }
                }else
                {
                    eventsIdToName[eventID] = eventName;
                    eventsParticipants[eventID] = new List<string>(participants);
                }


            }

            var events = eventsParticipants
                .Select(x => new
                {
                    It = x.Key,
                    Name = eventsIdToName[x.Key],
                    Participants = x.Value
                                .Distinct()
                                .OrderBy(p => p)
                                .ToList()
                })
                .OrderByDescending(x => x.Participants.Count())
                .ThenBy(x => x.Name)
                .ToList();

            foreach (var ev in events)
            {
                Console.WriteLine("{0} - {1}",ev.Name, ev.Participants.Count());

                foreach (var participant in ev.Participants)
                {
                    Console.WriteLine("{0}",participant);
                }
            }
        }
    }
}