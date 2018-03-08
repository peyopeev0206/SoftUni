using System;
					
public class Program
{
	public static void Main()
	{
        int numberOfdays = int.Parse(Console.ReadLine());
		double kmRunForFirstDay = double.Parse(Console.ReadLine());

		double totalKmRun = 0.0;
		double procenteg=0.0;
		double kmSum = 0.0;

		totalKmRun +=kmRunForFirstDay;
		kmSum+=totalKmRun;
		for (int i = 0; i < numberOfdays; i++)
		{
			int dailyPercentages = int.Parse(Console.ReadLine());
			procenteg = totalKmRun * dailyPercentages/100;
			//System.Console.WriteLine("procenteg {0} -> {1}",i ,procenteg);

			totalKmRun+=procenteg;
			// System.Console.WriteLine("totalKmRun {0} -> {1}",i ,totalKmRun);

			kmSum+=totalKmRun;
			// System.Console.WriteLine("kmSum {0} -> {1}",i ,kmSum);
		}

		if (kmSum >= 1000)
		{
			System.Console.WriteLine("You've done a great job running {0} more kilometers!",
				Math.Ceiling(kmSum-1000));
			
		}else
		{
			System.Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers",
				Math.Abs(Math.Ceiling(1000 - kmSum)));
		}
	}
}