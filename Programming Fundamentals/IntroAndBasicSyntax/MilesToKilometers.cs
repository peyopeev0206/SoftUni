using System;
					
public class MilesToKilometers
{
	public static void Main()
	{
		decimal miles = decimal.Parse(Console.ReadLine());

		System.Console.WriteLine("{0:0.00}",miles*1.60934m);
	}
}