using System;
namespace ConditionalStatementsAndLoopsHomework
{
    public class GameofNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int firstLastNumberCombination = 0;
            int secondLastNumberCombination = 0;

            int br = 0;
            bool found = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i+j==magicNumber)
                    {
                        firstLastNumberCombination=i;
                        secondLastNumberCombination=j;
                        found=true;
                    }
                    br++;
                }
            }

            if (found!=true)
            {
                System.Console.WriteLine("{0} combinations - neither equals {1}",br,magicNumber);

            }else
            {
                System.Console.WriteLine("Number found! {0} + {1} = {2}",firstLastNumberCombination,secondLastNumberCombination,
                firstLastNumberCombination+secondLastNumberCombination);
            }

        }
    }
}