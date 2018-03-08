using System;

namespace trip
{
    class trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    double sum = budget * 0.30;
                    Console.WriteLine($"Camp - {sum:f2}");
                }
                else
                {
                    double sum = budget * 0.70;
                    Console.WriteLine($"Hotel - {sum:f2}");
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    double sum = budget * 0.40;
                    Console.WriteLine($"Camp - {sum:f2}");
                }
                else
                {
                    double sum = budget * 0.80;
                    Console.WriteLine($"Hotel - {sum:f2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                double sum = budget * 0.90;
                Console.WriteLine($"Hotel - {sum:f2}");
            }
        }
    }
}
