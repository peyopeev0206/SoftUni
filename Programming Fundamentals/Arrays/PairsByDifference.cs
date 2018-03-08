using System;
using System.Linq;
using System.Collections.Generic;
namespace Arrays
{
    public class PairsByDifference
    {
        public static void Main(string[] args)
        {
            int[] numbers = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(System.Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j <numbers.Length; j++)
                {
                    if ((numbers[i]-numbers[j])==difference)
                    {
                        count++;
                    }
                }
            }

            System.Console.WriteLine(count);
            
        }
    }
}