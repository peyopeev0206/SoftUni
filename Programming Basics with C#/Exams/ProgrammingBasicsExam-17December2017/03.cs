using System;
					
public class Program
{
	public static void Main()
	{
        int numberOfNights = int.Parse(Console.ReadLine());
		string typeOfDestination = Console.ReadLine().ToLower();
		string typeOfTransport = Console.ReadLine().ToLower();
		
		double destinationCost = 0.0;
		double destinationCostWithDog = 0.0;
		double totalDestinationCost = 0.0;
		double priceForTransport = 0.0;

		if (typeOfDestination == "miami")
		{
			if (numberOfNights <= 10)
			{
				destinationCost = numberOfNights * (2*24.99 + 3 * 14.99);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
				
			}else if (numberOfNights<=15)
			{
				destinationCost = numberOfNights * (2*22.99 + 3 * 11.99);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
			}else if (numberOfNights>15)
			{
				destinationCost = numberOfNights * (2*20 + 3 * 10);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
			}
		}else if(typeOfDestination == "canary islands")
		{
			if (numberOfNights <= 10)
			{
				destinationCost = numberOfNights * (2*32.50 + 3 * 28.50);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
				
			}else if (numberOfNights<=15)
			{
				destinationCost = numberOfNights * (2*30.50 + 3 * 25.60);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
			}else if (numberOfNights>15)
			{
				destinationCost = numberOfNights * (2*28 + 3 * 22);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
			}
		}else if(typeOfDestination == "philippines")
		{
			if (numberOfNights <= 10)
			{
				destinationCost = numberOfNights * (2 * 42.99 + 3 * 39.99);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
				
			}else if (numberOfNights<=15)
			{
				destinationCost = numberOfNights * (2*41.00 + 3 * 36.00);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
			}else if (numberOfNights>15)
			{
				destinationCost = numberOfNights * (2*38.50 + 3 * 32.40);
				destinationCostWithDog = destinationCost * 0.25;
				totalDestinationCost = destinationCost + destinationCostWithDog;
			}
		}

		if (typeOfTransport=="train")
		{
			priceForTransport = 2 * 22.30 + 3 * 12.50;
		}else if (typeOfTransport=="bus")
		{
			priceForTransport = 2 * 45.00 + 3 * 37.00;
		}else if (typeOfTransport=="airplane")
		{
			priceForTransport = 2*90 + 3*68.50;
		}
		
		System.Console.WriteLine("{0:0.000}",totalDestinationCost+priceForTransport);
	}
}