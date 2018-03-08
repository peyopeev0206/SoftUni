using System.Collections.Generic;

namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class PrimesInGivenRange
    {
        public static void Main(string[] args)
        {
            int startNumber = int.Parse(System.Console.ReadLine());
            int endNumber = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(string.Join(", ", isPrime(startNumber,endNumber).ToArray()));
        }
        static List<int> isPrime(int start, int stop)
        {
            List<int> result = new List<int>();
            for (int i = start; i <= stop; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}