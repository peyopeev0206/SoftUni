using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfField = int.Parse(Console.ReadLine());

            var field = new int[sizeOfField];

            Console.ReadLine()//ladybugField
                        .Split(' ')
                        .Select(i => int.Parse(i))
                        .Where(i => i >= 0 && i < sizeOfField)
                        .ToList()
                        .ForEach(i => field[i] = 1);//ladybug population


            //foreach (var index in ladybugField)
            //{
            //    ladybugField[index] = 1;
            //}


            while (true)
            {

                var commands = Console.ReadLine()
                                                .Split()
                                                .ToArray(); //1 left 5
                if (commands[0] == "end")
                {
                    break;
                }

                var ladybugIndex = int.Parse(commands[0]); //1
                var direction = commands[1]; //left(-) / right(+)
                var flyLenght = int.Parse(commands[2]); //5

                if (direction == "left")
                {
                    flyLenght *= -1;
                }

                if (ladybugIndex < 0 || ladybugIndex >= sizeOfField)
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;

                var landIndex = ladybugIndex;
                while (true)
                {
                    landIndex += flyLenght;
                    if (landIndex < 0 || landIndex >= sizeOfField)
                    {
                        break;
                    }

                    if (field[landIndex] == 1)
                    {
                        continue;
                    }

                    field[landIndex] = 1;
                    break;

                }

            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}