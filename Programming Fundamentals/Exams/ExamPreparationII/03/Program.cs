﻿using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var demonsInput = Console.ReadLine()
                                     .Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                                     .OrderBy(d => d)
                                      .ToList();

            foreach (string demon in demonsInput)
            {
                double demonHealth = GetDemonHealth(demon);
                decimal demonDamage = GetDemonDamage(demon);
                Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:F2} damage");
            }
        }

        private static decimal GetDemonDamage(string demon)
        {
            string demontDamagePattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            Regex regex = new Regex(demontDamagePattern);
            MatchCollection collection = regex.Matches(demon);
            decimal damage = 0;
            foreach (var number in collection)
            {
                damage += decimal.Parse(number.ToString());
            }

            foreach (char c in demon.Where(c => c == '*' || c == '/'))
            {
                if (c == '*')
                {
                    damage *= 2;
                }
                else
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        private static double GetDemonHealth(string demon)
        {
            string demonHealthPattern = @"[^\d\.\+\-\*\/\s\,]";
            Regex regex = new Regex(demonHealthPattern);
            MatchCollection collection = regex.Matches(demon);
            double health = 0;
            foreach (Match str in collection)
            {
                foreach (char c in str.ToString())
                {
                    health += (int)c;
                }
            }

            return health;
        }
    }
}
