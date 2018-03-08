using System;
using System.Linq;
namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine()
                               .Split()
                               .Select(x => int.Parse(x))
                               .ToArray();
            int startPosition = int.Parse(Console.ReadLine());

            string line = string.Empty;
            int initialDamage = 1;
            while ((line = Console.ReadLine()) != "Supernova")
            {
                string[] commands = line
                    .Split();

                string direction = commands[0];
                int steps = int.Parse(commands[1]);


                if (direction == "left")
                {
                    seq = DirectionLeft(seq,ref startPosition, steps, ref initialDamage);
                }else if (direction == "right")
                {

                    seq = DirectionRight(seq,ref startPosition, steps, ref initialDamage);
                }
            }
            Console.WriteLine(string.Join(" ", seq));
        }

        private static int[] DirectionRight(int[] array,ref int startPosition, int steps, ref int initialDamage)
        {
            while (steps != 0)
            {

                if (startPosition >= array.Length-1)
                {
                    startPosition = -1;
                    initialDamage++;
                }
                array[++startPosition] -= initialDamage;

                steps--;
            }
            return array;
        }

        private static int[] DirectionLeft(int[] array, ref int startPosition, int steps, ref int initialDamage)
        {

            while (steps != 0)
            {

                if (startPosition<=0)
                {
                    startPosition = array.Length;
                    initialDamage++;
                }
                array[--startPosition] -=initialDamage;

                steps--;
            }
            return array;
        }
    }
}
