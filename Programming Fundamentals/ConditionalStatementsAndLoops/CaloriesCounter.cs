using System;

public class CaloriesCounter
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int calSum=0;

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine().ToLower();

            if (word=="cheese")
            {
                calSum+=500;
            }else if(word=="tomato sauce")
            {
                calSum+=150;
            }else if(word=="salami")
            {
                calSum+=600;
            }else if(word=="pepper")
            {
                calSum+=50;
            }
            
        }
        System.Console.WriteLine("Total calories: {0}",calSum);
    }
}