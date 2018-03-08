using System;

namespace gameTicket
{
    class gameTicket
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            decimal tickets = 0.0m;

            if (people >= 1 && people <= 4)
            {
                budget = budget * (decimal)0.25;
                if (category == "vip")
                {
                    tickets = (decimal)people * (decimal)499.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
                else
                {
                    tickets = (decimal)people * (decimal)249.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
            }
            else if (people >= 5 && people <= 9)
            {
                budget = budget * (decimal)0.40;
                if (category == "vip")
                {
                    tickets = (decimal)people * (decimal)499.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
                else
                {
                    tickets = (decimal)people * (decimal)249.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
            }
            else if (people >= 10 && people <= 24)
            {
                budget = budget * (decimal)0.50;
                if (category == "vip")
                {
                    tickets = (decimal)people * (decimal)499.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
                else
                {
                    tickets = (decimal)people * (decimal)249.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
            }
            else if (people >= 25 && people <= 49)
            {
                budget = budget * (decimal)0.60;
                if (category == "vip")
                {
                    tickets = (decimal)people * (decimal)499.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
                else
                {
                    tickets = (decimal)people * (decimal)249.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
            }
            else
            {
                budget = budget * (decimal)0.75;
                if (category == "vip")
                {
                    tickets = (decimal)people * (decimal)499.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
                else
                {
                    tickets = (decimal)people * (decimal)249.99;
                    decimal res = budget - tickets;
                    if (res >= 0)
                    {
                        Console.WriteLine($"Yes! You have {res:f2} leva left.");
                    }
                    else
                    {
                        res = tickets - budget;
                        Console.WriteLine($"Not enough money! You need {res:f2} leva.");
                    }
                }
            }
        }
    }
}