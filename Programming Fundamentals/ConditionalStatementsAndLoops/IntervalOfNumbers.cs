using System;

public class IntervalOfNumbers
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        if (start>end)
        {
            int help = start;
            start = end;
            end = help;
        }
        for (int i = start; i <= end; i++)
        {
            System.Console.WriteLine(i);
        }
    }
}