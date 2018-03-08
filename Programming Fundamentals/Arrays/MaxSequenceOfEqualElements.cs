using System;
using System.Linq;
namespace Arrays
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int count = 0;
            int max = 0;
            for (int i = 0; i < arrayInput.Length-1; i++)
            {
                if (arrayInput[i]==arrayInput[i+1])
                {                    
                    count++;
                    if (count > max)
                    {
                        start = i - count;
                        max = count;                        
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = start+1 ; i <= start+max+1; i++)
            {
                Console.Write(arrayInput[i]+" ");
            }
            
        }
    }
}