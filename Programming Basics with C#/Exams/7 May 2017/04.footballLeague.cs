using System;

namespace footballLeague
{
    class footballLeague
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double numberOfAllFans = double.Parse(Console.ReadLine());
            double brA = 0;
            double brB = 0;
            double brV = 0;
            double brG = 0;
            for (int i = 0; i < numberOfAllFans; i++)
            {
                string sector = Console.ReadLine().ToLower();
                if (sector == "a")
                {
                    brA++;
                }else if (sector == "b")
                {
                    brB++;
                }else if (sector == "v")
                {
                    brV++;
                }else if (sector == "g")
                {
                    brG++;
                }
            }

            System.Console.WriteLine("{0:0.00}%",100*brA/numberOfAllFans);
            System.Console.WriteLine("{0:0.00}%",100*brB/numberOfAllFans);
            System.Console.WriteLine("{0:0.00}%",100*brV/numberOfAllFans);
            System.Console.WriteLine("{0:0.00}%",100*brG/numberOfAllFans);
            System.Console.WriteLine("{0:0.00}%",100*numberOfAllFans/stadiumCapacity);
        }
    }
}