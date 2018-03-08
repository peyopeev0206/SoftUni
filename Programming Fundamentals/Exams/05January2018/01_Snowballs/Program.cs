using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01_Snowballs {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            var listOfAllValues = new List<Tuple<int, int, BigInteger, int>> ();
            for (int i = 0; i < n; i++) {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = calculateSnowballValue (snowballSnow, snowballTime, snowballQuality);
                var snowballValueInTuple = new Tuple<int, int, BigInteger, int>
                    (snowballSnow, snowballTime, snowballValue, snowballQuality);
                listOfAllValues.Add (snowballValueInTuple);
            }

            var highestSnowBallValue = listOfAllValues.OrderByDescending (x => x.Item3).First ();
            System.Console.WriteLine ("{0} : {1} = {2} ({3})",
                highestSnowBallValue.Item1,
                highestSnowBallValue.Item2,
                highestSnowBallValue.Item3,
                highestSnowBallValue.Item4
            );

        }

        public static BigInteger calculateSnowballValue (int snow, int time, int quality) {
            return BigInteger.Pow ((snow / time), quality);
        }
    }
}