using System;
					
public class ChooseDrink
{
	public static void Main()
	{
        string profession = Console.ReadLine().ToLower();
        
        if (profession == "athlete")
            System.Console.WriteLine("Water");
            
        else if (profession == "businessman" || profession=="businesswoman")
            System.Console.WriteLine("Coffee");
        
            
        else if (profession == "softuni student")
            System.Console.WriteLine("Beer");
        
            
        else 
            System.Console.WriteLine("Tea");
        
            
        
	}
}