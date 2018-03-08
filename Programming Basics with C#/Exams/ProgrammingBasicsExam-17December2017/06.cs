using System;
					
public class Program
{
	public static void Main()
	{
        int n = int.Parse(Console.ReadLine());
	
		string inputToString=n.ToString();
		char first = inputToString[0];
		char second = inputToString[1];
		char third = inputToString[2];

		int firstNumber = first - '0';
		int secondNumber = second - '0';
		int thirthNumber = third - '0';

		for (int q = 1; q <= thirthNumber; q++)
		{
			for (int w = 1; w <= secondNumber; w++)
			{
				for (int e = 1; e <= firstNumber; e++)
				{
					System.Console.WriteLine("{0} * {1} * {2} = {3};",
						q,w,e,q*w*e);
				}
			}
		}
	}


}