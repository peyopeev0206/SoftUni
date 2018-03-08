using System;

public class CakeIngredients
{
    public static void Main()
    {
        string ingredient = Console.ReadLine();
        int numbersOfIngredient=0;
        while (ingredient!="Bake!")
        {
            System.Console.WriteLine($"Adding ingredient {ingredient}.");
            ingredient = Console.ReadLine();
            numbersOfIngredient++;
        }

        System.Console.WriteLine("Preparing cake with {0} ingredients.", numbersOfIngredient);
    }
}