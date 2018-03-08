using System;

namespace operationsBetweenNumbers
{
    class operationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            double numberOne = int.Parse(Console.ReadLine());
            double numberTwo = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (operation == '+')
                {
                    double result = numberOne + numberTwo;
                    if (result % 2 == 0)
                    {
                        System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - even");
                    }else
                    {
                        System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - odd");
                    }
                }else if (operation == '-')
                {
                    double result = numberOne - numberTwo;
                    if (result % 2 == 0)
                    {
                        System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - even");
                    }else
                    {
                        System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - odd");
                    }
                }else if (operation == '*')
                {
                    double result = numberOne * numberTwo;
                    if (result % 2 == 0)
                    {
                        System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - even");
                    }else
                    {
                        System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - odd");
                    }
                }
            }else if (numberTwo != 0)
            {
                if (operation =='/')
                {
                    double result = numberOne / numberTwo;
                    System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result:f2}");
                }else if (operation == '%')
                {
                    double result = numberOne % numberTwo;
                    System.Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result}");
                }
            }else
            {
                System.Console.WriteLine($"Cannot divide {numberOne} by zero");
            }
        }
    }
}
