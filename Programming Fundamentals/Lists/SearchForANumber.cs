using System;
using System.Collections.Generic;
using System.Linq;
namespace Lists
{
    public class SearchForANumber
    {
        public static void Main(string[] args)
        {
            List<int> inputListNumbers = Console.ReadLine()
                                        .Split(' ')
                                        .Select(int.Parse)
                                        .ToList();
            int[] changes=Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            
            List<int> takeElements = inputListNumbers.Take(changes[0]).ToList();
            takeElements = takeElements.Skip(changes[1]).ToList();
            if (takeElements.Contains(changes[2]))
                System.Console.WriteLine("YES!");
            else
                System.Console.WriteLine("NO!");
        }
    }
}