using System;

class fort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sizeIfCols = n / 2;
        int sizeOfMiddle = 2 * n - 2 * sizeIfCols - 4;

        // Draw the first row
        Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', sizeIfCols),
            new string('_', sizeOfMiddle));

        // Middle rows
        for (int row = 1; row <= n-3; row++)
            Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));

        // Draw the row before the last
        Console.WriteLine("|{0}{1}{0}|",
            new string(' ', sizeIfCols + 1),
            new string('_', sizeOfMiddle));

        // Draw the last row
        Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', sizeIfCols),
            new string(' ', sizeOfMiddle));
    }
}

