using System;
					
public class ChooseDrinkSecond
{
	public static void Main()
	{
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        if (profession == "Athlete")
        {
            System.Console.WriteLine("The {0} has to pay {1:0.00}.",profession,(double)quantity*0.70);
        }    
        else if (profession == "Businessman" || profession=="Businesswoman")
        {
            System.Console.WriteLine("The {0} has to pay {1:0.00}.",profession,(double)quantity*1.00);
        }
            
        else if (profession == "SoftUni Student")
        {
            System.Console.WriteLine("The {0} has to pay {1:0.00}.",profession,(double)quantity*1.70);
        }
            
        else 
        {
            System.Console.WriteLine("The {0} has to pay {1:0.00}.",profession,(double)quantity*1.20);
        }
            
        
	}
}