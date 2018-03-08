using System;
namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokeCounter = 0;
            int leftPower = pokePower;

            while (leftPower >= distance)
            {
                
                leftPower -= distance;
                pokeCounter++;

                if (leftPower == pokePower / 2 && pokePower % 2 == 0 && exhaustionFactor != 0)
                {
                    leftPower /= exhaustionFactor;
                }
            }

            Console.WriteLine(leftPower);
            Console.WriteLine(pokeCounter);

        }
    }
}
