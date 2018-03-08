using System;
using System.Collections.Generic;
using System.Linq;
namespace Lists
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            List<int> inputListNumbers = Console.ReadLine()
                                        .Split(' ')
                                        .Select(int.Parse)
                                        .ToList();
            int currentSeqStartIndex = 0;
            int currentSeqLength = 1;
            int longestSeqStartIndex = 0;
            int longestSeqLength = 1;

            for (int i = 0; i < inputListNumbers.Count-1; i++)
            {
                 if (inputListNumbers[i] == inputListNumbers[i+1])
                {
                    currentSeqLength++;
                    if(currentSeqLength > longestSeqLength)
                    {
                        longestSeqLength = currentSeqLength;
                        longestSeqStartIndex = currentSeqStartIndex;
                    }
                }
                else
                {
                    currentSeqStartIndex = i + 1;
                    currentSeqLength = 1;
                }
            }
            System.Console.WriteLine(string.Join(" ",inputListNumbers.Skip(longestSeqStartIndex).Take(longestSeqLength)));
        }
    }
}