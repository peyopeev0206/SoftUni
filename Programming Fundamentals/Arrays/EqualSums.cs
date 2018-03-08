using System;
using System.Linq;
namespace Arrays
{
    public class EqualSums
    {
        public static void Main(string[] args)
        {
            int[] numbersInput = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            bool foundEqualSums = false;

            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (numbersInput.Take(i).Sum() == numbersInput.Skip(i+1).Sum())
                {
                    System.Console.WriteLine(i);
                    foundEqualSums=true;
                    break;
                }
            }
            if (!foundEqualSums)
            {
                System.Console.WriteLine("no");
            }
                                                        
        }
    }
}