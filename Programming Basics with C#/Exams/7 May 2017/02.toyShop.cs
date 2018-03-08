using System;

namespace toyShop
{
    class toyShop
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzels = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double priceOfPuzzel = 2.60;
            double priceOfTalkingDolls = 3;
            double priceOfTeddyBears = 4.10;
            double priceOfMinions = 8.20;
            double priceOfTrucks = 2;
            double discount = 0.0;
            double finalPrice = 0.0;
            double rent = 0.0;
            double profit = 0.0;

            double sum = (numberOfPuzzels * priceOfPuzzel) +
                            (numberOfTalkingDolls * priceOfTalkingDolls) +
                            (numberOfTeddyBears * priceOfTeddyBears) +
                            (numberOfMinions * priceOfMinions) +
                            (numberOfTrucks * priceOfTrucks);

            int numberOfToys = numberOfPuzzels + 
                                numberOfTalkingDolls +
                                numberOfTeddyBears +
                                numberOfMinions +
                                numberOfTrucks;

            if (numberOfToys >= 50)
            {
                discount = sum * 0.25;
            }

            finalPrice = sum - discount;
            rent = finalPrice * 0.1;

            profit = finalPrice - rent;

            if (profit >= tripPrice)
            {
                System.Console.WriteLine("Yes! {0:0.00} lv left.", profit-tripPrice);
            }else
            {
                System.Console.WriteLine("Not enough money! {0:0.00} lv needed.", tripPrice - profit);
            }

            
        }
    }
}