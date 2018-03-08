using System;
using System.Linq;
namespace Arrays
{
    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] rowLeft = arr.Take(k).Reverse().ToArray();
            int[] rowRight = arr.Reverse().Take(k).ToArray();
            int[] rowFirst = rowLeft.Concat(rowRight).ToArray();
            int[] rowSecond = arr.Skip(k).Take(2 * k).ToArray();
            int[] arrSum = rowFirst.Select((x, index) => x + rowSecond[index]).ToArray();
            Console.WriteLine(string.Join(" ",arrSum));  
        }
    }
}