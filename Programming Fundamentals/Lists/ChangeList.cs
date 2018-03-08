using System;
using System.Collections.Generic;
using System.Linq;
namespace Lists
{
    public class ChangeList
    {
        public static void Main(string[] args)
        {
            List<int> inputListNumbers = Console.ReadLine()
                                        .Split(' ')
                                        .Select(int.Parse)
                                        .ToList();
           string commands = Console.ReadLine();
           
            
            while (commands != "Even" && commands !="Odd")
            {
                string[] tokens = commands.Split();
                if (tokens[0]=="Delete")
                {
                    inputListNumbers.RemoveAll(r=> r==int.Parse(tokens[1]));
                }else if (tokens[0]=="Insert")
                {
                    inputListNumbers.Insert(int.Parse(tokens[2]),int.Parse(tokens[1]));
                }
                commands = Console.ReadLine();  
            }
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i <inputListNumbers.Count; i++)
            {
                if (inputListNumbers[i]%2==0)
                {
                    even.Add(inputListNumbers[i]);
                }else
                {
                    odd.Add(inputListNumbers[i]);   
                }
            }
            if (commands=="Odd")
            {
                System.Console.WriteLine(string.Join(" ",odd));
            }else
            {
                System.Console.WriteLine(string.Join(" ",even));
            }
            
        }
    }
}