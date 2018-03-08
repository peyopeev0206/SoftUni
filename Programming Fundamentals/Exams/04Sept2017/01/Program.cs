using System;
using System.Numerics;
namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPhoenixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfPhoenixes; i++)
            {
                int totalLengthOfBody = int.Parse(Console.ReadLine());
                decimal totalWidthOfBody = decimal.Parse(Console.ReadLine());
                decimal lengthOfOneWing = decimal.Parse(Console.ReadLine());

                decimal totalYears = (decimal)Math.Pow(totalLengthOfBody, 2) * (totalWidthOfBody + 2m * lengthOfOneWing);
                Console.WriteLine(totalYears);
            }
        }
    }
}
