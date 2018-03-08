using System;
using System.Collections.Generic;
using System.Linq;
namespace Lists
{
    public class BombNumbers
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            int[] specialPower = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToArray();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == specialPower[0])
                {
                    if (specialPower[1] <= i)
                    {
                        for (int j = i; j >= i-specialPower[1]; j--)
                        {
                            input[j] = 0;
                        }
                    }
                    if (specialPower[1] > i)
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            input[j] = 0;
                        }
                    }
                    if (specialPower[1] + i >= input.Count -1)
                    {
                        for (int j = i; j < input.Count; j++)
                        {
                            input[j] = 0;
                        }
                    }
                    if (specialPower[1] + i < input.Count - 1)
                    {
                        for (int j = i; j <= specialPower[1] + i; j++)
                        {
                            input[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(input.Sum());
        }
    }
}