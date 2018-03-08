using System;

public class TriangleOfNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}