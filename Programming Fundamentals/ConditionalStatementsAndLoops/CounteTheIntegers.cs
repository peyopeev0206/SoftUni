using System;

public class CounteTheIntegers
{
    public static void Main()
    {
        int totalInputsAsIntegers = 0;
        while (true)
        {
            string input = Console.ReadLine();
            try
            {
                int.Parse(input);
                totalInputsAsIntegers++;
            }
            catch 
            {
                System.Console.WriteLine(totalInputsAsIntegers);
                break;
            }
        }
    }
}