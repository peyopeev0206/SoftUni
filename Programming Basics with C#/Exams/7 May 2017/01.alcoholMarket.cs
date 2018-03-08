using System;

namespace alcoholMarket
{
    class alcoholMarket
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiqQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiqPrice = whiskeyPrice/2;
            double winePrice = rakiqPrice - (0.4 * rakiqPrice);
            double beerPrice = rakiqPrice - (0.8 * rakiqPrice);

            double rakiqSum = rakiqQuantity * rakiqPrice;
            double wineSum = wineQuantity * winePrice;
            double beerSum = beerQuantity * beerPrice;
            double whiskeySum = whiskeyQuantity * whiskeyPrice;

            double total = rakiqSum + wineSum + beerSum + whiskeySum;
            System.Console.WriteLine("{0:0.00}",total);
        }
    }
}