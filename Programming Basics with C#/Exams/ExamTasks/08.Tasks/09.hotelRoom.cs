using System;

namespace hotelRoom
{
    class hotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double res, apres = 0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights < 15)
                {
                    res = nights * 47.5;
                    apres = nights * 65;
                    Console.WriteLine($"Apartment: {apres:f2} lv.");
                    Console.WriteLine($"Studio: {res:f2} lv.");
                }
                else if (nights > 14)
                {
                    res = nights * 35;
                    apres = nights * 58.5;
                    Console.WriteLine($"Apartment: {apres:f2} lv.");
                    Console.WriteLine($"Studio: {res:f2} lv.");
                }
                else
                {
                    res = nights * 50;
                    apres = nights * 65;
                    Console.WriteLine($"Apartment: {apres:f2} lv.");
                    Console.WriteLine($"Studio: {res:f2} lv.");
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    res = nights * 60.16;
                    apres = nights * 61.83;
                    Console.WriteLine($"Apartment: {apres:f2} lv.");
                    Console.WriteLine($"Studio: {res:f2} lv.");
                }
                else
                {
                    res = nights * 75.2;
                    apres = nights * 68.7;
                    Console.WriteLine($"Apartment: {apres:f2} lv.");
                    Console.WriteLine($"Studio: {res:f2} lv.");
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    res = nights * 76;
                    apres = nights * 69.3;
                    Console.WriteLine($"Apartment: {apres:f2} lv.");
                    Console.WriteLine($"Studio: {res:f2} lv.");
                }
                else
                {
                    res = nights * 76;
                    apres = nights * 77;
                    Console.WriteLine($"Apartment: {apres:f2} lv.");
                    Console.WriteLine($"Studio: {res:f2} lv.");
                }
            }
        }
    }
}