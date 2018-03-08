using System;
using System.Linq;
namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                               .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();
            
            string text = string.Empty;

            while ((text = Console.ReadLine()) != "end")
            {
                string[] commands = text
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();

                if (commands[0] == "reverse")
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);
                    input = Reverse(input,start,count);
                }else if (commands[0] == "sort")
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);
                    input = Sort(input,start,count);
                }else if(commands[0] == "rollLeft")
                {
                    int count = int.Parse(commands[1]);
                    input = RoolLeft(input,count);
                    
                }else if (commands[0] == "rollRight")
                {
                    int count = int.Parse(commands[1]);
                    input = RoolRight(input, count);

                }
            }
            Console.WriteLine("[{0}]",string.Join(", ", input));
        }

        static string[] Reverse(string[] array, int start, int count)
        {
            if (start < 0 || start >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            if (start + count < 0 || count < 0 || start+count - 1 >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }
            //1 2 5 8 7 3 10 6 4 9
            //2 -> 4
            //
            string[] firstPart = array.Take(start).ToArray();
            string[] reverseOart = array.Skip(start).Take(count).Reverse().ToArray();
            string[] lastPart = array.Skip(start + count).ToArray();

            return firstPart.Concat(reverseOart).Concat(lastPart).ToArray();
        }

        static string[] Sort(string[] array, int start, int count)
        {
            if (start < 0 || start >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            if (start + count < 0 || count < 0 || start + count - 1 >= array.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }

            string[] firstPart = array.Take(start).ToArray();
            string[] arrayForSorting = array.Skip(start).Take(count).OrderBy(x=>x).ToArray();
            string[] lastPart = array.Skip(start + count).ToArray();

            return firstPart.Concat(arrayForSorting).Concat(lastPart).ToArray();
        }

        static string[] RoolLeft(string[] array, int count)
        {
            if (count<0)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;

            }

            count %= array.Length;
            string[] firstPart = array.Take(count).ToArray();
            string[] secondPart = array.Skip(count).ToArray();

            return secondPart.Concat(firstPart).ToArray();
        }

        static string[] RoolRight(string[] array, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;

            }
            //1 2 3 4 5
            count %= array.Length;
            string[] firstPart = array.Skip(array.Length - count).ToArray();
            string[] secondPart = array.Take(array.Length - count).ToArray();

            return firstPart.Concat(secondPart).ToArray();
        }
    }
}
