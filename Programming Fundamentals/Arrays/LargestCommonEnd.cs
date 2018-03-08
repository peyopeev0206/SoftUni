using System;
using System.Linq;
namespace Arrays
{
    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            string[] firstArrayInput = Console.ReadLine().Split(' ').ToArray();
            string[] secondArrayInput = Console.ReadLine().Split(' ').ToArray();

            int lengthL = 0;
            int lengthR = 0;
            for (int i = 0; i < Math.Min(firstArrayInput.Length, secondArrayInput.Length); i++)
            {
                if (firstArrayInput[i] == secondArrayInput[i])
                    lengthL++;
                if (firstArrayInput[firstArrayInput.Length - 1 - i] == secondArrayInput[secondArrayInput.Length - 1 - i])
                    lengthR++;
            }
            if (lengthL >= lengthR)
                Console.WriteLine(lengthL);
            else
                Console.WriteLine(lengthR);
        }
    }
}