using System;
					
public class CharacterStats
{
	public static void Main()
	{
        string name = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maximumHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maximumEnergy = int.Parse(Console.ReadLine());
        
       System.Console.WriteLine($"Name: {name}");
       System.Console.WriteLine("Health: |{0}{1}|",new string('|',currentHealth),new string('.',maximumHealth-currentHealth));
       System.Console.WriteLine("Energy: |{0}{1}|",new string('|',currentEnergy),new string('.',maximumEnergy-currentEnergy));
	}
}