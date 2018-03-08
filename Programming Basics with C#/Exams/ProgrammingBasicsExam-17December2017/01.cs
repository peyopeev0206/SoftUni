using System;
					
public class Program
{
	public static void Main()
	{
        double budget = double.Parse(Console.ReadLine());
        double firstKidPresentPrice = double.Parse(Console.ReadLine());
        double secondKidPresentPrice = double.Parse(Console.ReadLine());
        double thirdKidPresentPrice = double.Parse(Console.ReadLine());

        double totalSumOfPresents = 0.0;
        double bidgetLeft = 0.0;
        double bidgetWithTaxes = 0.0;

        totalSumOfPresents = firstKidPresentPrice + secondKidPresentPrice + thirdKidPresentPrice;
        bidgetLeft = budget - totalSumOfPresents;
        bidgetWithTaxes = bidgetLeft * 0.1;

        System.Console.WriteLine($"{bidgetLeft-bidgetWithTaxes:0.00}");

	}
}