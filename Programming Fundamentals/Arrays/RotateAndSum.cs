using System;
using System.Linq;
namespace Arrays
{
    public class RotateAndSum
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] numbers = new int[input.Length];
            int[] sumArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < rotations; i++)
            {
                int lastNumber = numbers[numbers.Length - 1];
                for (int j = numbers.Length -1 ; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastNumber;
                for (int q = 0; q < numbers.Length; q++)
                {
                    sumArray[q] += numbers[q];
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(sumArray[i]+ " ");
            } 
        }
    }
}