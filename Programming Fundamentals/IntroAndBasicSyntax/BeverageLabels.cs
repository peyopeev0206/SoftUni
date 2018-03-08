using System;
					
public class BeverageLabels
{
	public static void Main()
	{
                string name = Console.ReadLine();
                int volume = int.Parse(Console.ReadLine());
                int energy = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                
                System.Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars",volume,name,(volume*energy)/100.00,(sugar*volume)/100.00);
	}
}