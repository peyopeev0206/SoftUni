using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                         .Split()
                         .ToList();
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "3:1")
            {
                var commands = line.Split().ToArray();
                if (commands[0] == "merge")
                {
                    int startIndex = (CheckIndex(int.Parse(commands[1]), data.Count));
                    int endIndex = (CheckIndex(int.Parse(commands[2]), data.Count));

                    data = Merge(data,startIndex,endIndex);

                }else if (commands[0] == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    data = Divide(data, index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", data));
        }

        private static List<string> Merge(List<string> sensitiveData, int startIndex, int endIndex)
        {

            List<string> newList = new List<string>();

            //newList.AddRange(sensitiveData);
            for (int i = 0; i < startIndex; i++)
            {
                newList.Add(sensitiveData[i]);
            }

            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(sensitiveData[i]);
            }

            newList.Add(result.ToString());

            for (int i = endIndex + 1; i < sensitiveData.Count; i++)
            {
                newList.Add(sensitiveData[i]);
            }

            return newList;
        }

        private static List<string> Divide(List<string> data, int index, int partitions)
        {
            string element = data[index];

            int partitionLength = element.Length / partitions;

            List<string> dividedPartitions = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength));
                }
                else
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength, partitionLength));
                }
            }

          
            data.RemoveAt(index);
            data.InsertRange(index, dividedPartitions);

            return data;
        }

        private static int CheckIndex(int index, int maxLength)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index >= maxLength)
            {
                index = maxLength - 1;
            }

            return index;
        }
    }
}
