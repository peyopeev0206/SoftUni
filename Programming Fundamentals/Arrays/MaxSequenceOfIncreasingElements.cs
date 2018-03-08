using System;
using System.Linq;
namespace Arrays
{
    public class MaxSequenceOfIncreasingElements
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
 
            MaxIncSequence(numbers, numbers.Length);
        }

         static void MaxIncSequence(int[] numbers, int l)
        {
            int cntCurrSeq = 0;
            int startCurrSeq = 0;
            int cntMaxSeq = 0;
            int startMaxSeq = 0;
 
            for (int i = 1; i < l; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    cntCurrSeq++;
                    startCurrSeq = i - cntCurrSeq;
 
                    if (cntCurrSeq > cntMaxSeq)
                    {
                        cntMaxSeq = cntCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    cntCurrSeq = 0;
                }
            }
            for (int iWrite = startMaxSeq; iWrite <= (startMaxSeq + cntMaxSeq); iWrite++)
            {
                Console.Write(numbers[iWrite] + " ");
            }
            Console.WriteLine();
        }
    }
}