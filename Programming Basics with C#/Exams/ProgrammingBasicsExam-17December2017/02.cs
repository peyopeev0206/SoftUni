using System;
					
public class Program
{
	public static void Main()
	{
        int guestNumber = int.Parse(Console.ReadLine());
		int budget = int.Parse(Console.ReadLine());

		int priceForCouvert = 0;
		int leftMoneyAfterCouvert = 0;
		double moneyForFireworks = 0.0;
		double moneyForDonation = 0.0;

		priceForCouvert = guestNumber * 20;

		if (priceForCouvert>budget)
		{
			System.Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more.",
				Math.Abs(priceForCouvert-budget));
		}else
		{
			leftMoneyAfterCouvert = budget - priceForCouvert;
			moneyForFireworks = leftMoneyAfterCouvert * 0.4;
			moneyForDonation = leftMoneyAfterCouvert - moneyForFireworks;
			System.Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation.",
				Math.Round(moneyForFireworks),Math.Round(moneyForDonation));
		}
	}
}