using System;
					
public class DebitCardNumber
{
	public static void Main()
	{
		int numberOne = int.Parse(Console.ReadLine());
		int numberTwo = int.Parse(Console.ReadLine());
		int numberThree = int.Parse(Console.ReadLine());
		int numberFour = int.Parse(Console.ReadLine());

		System.Console.WriteLine($"{numberOne:0000} {numberTwo:0000} {numberThree:0000} {numberFour:0000}");
	}
}