using System;
using System.Collections.Generic;
using System.Linq;
namespace DictionariesLambdaAndLINQ
{
    public class HandsOfCards
    {
        public static void Main(string[] args)
        {
            var personHands = new Dictionary<string, List<string>>();
            string  input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] playerCards = input.Split(':').ToArray();
                string[] cards = playerCards[1]
                    .TrimStart()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!personHands.ContainsKey(playerCards[0]))
                    personHands.Add(playerCards[0], new List<string>());
                
                personHands[playerCards[0]].AddRange(cards);
 
                input = Console.ReadLine();
            }

            foreach (var kvp in personHands)
            {
                string playerName = kvp.Key;
                List<string> cards = kvp.Value.Distinct().ToList();
 
                int sum = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1).Trim();
                    string suite = card.Substring(card.Length - 1);
 
                    int rankPower = PowerOfCards(rank);
                    int suitePower = TypeOfCards(suite);
 
                    sum += rankPower * suitePower;
                }
                Console.WriteLine($"{playerName}: {sum}");
            }
        }
        private static int PowerOfCards(string powerOfCard)
        {
            switch (powerOfCard)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
 
                default:
                    return 1;
 
            }
        }

         private static int TypeOfCards(string multiplier)
        {
            switch (multiplier)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }
    }
}