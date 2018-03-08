using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number which index we are going to looking for:");
            int S = int.Parse(Console.ReadLine());

            int[] num = new int[N];
            Console.WriteLine("Enter the elements of the array.", N);
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter the " + i + " element of the array: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            int index = BinaryS(num, S, 0, num.Length);

            if (index != -1) Console.WriteLine("Number {0} found at index: {1}", S, index);
            else Console.WriteLine("Number {0} not found!", S);
        }

        private static int BinaryS(int[] nums, int value, int start, int end)
        {
            if (end < start)
            {
                return -1;
            }
            else
            {
                int middleIndex = (start + end) / 2;
                if (nums[middleIndex] > value)
                {
                    return BinaryS(nums, value, start, middleIndex - 1);
                }
                else if (nums[middleIndex] < value)
                {
                    return BinaryS(nums, value, middleIndex + 1, end);
                }
                else
                {
                    return middleIndex;
                }
            }
        }
    }
}