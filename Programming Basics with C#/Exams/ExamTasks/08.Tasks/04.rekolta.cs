using System;
namespace rekolta
{
    class rekolta
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = X * Y;
            double wine = totalGrapes * 0.40 / 2.5;
            
            if (wine  >= Z)
            {   
            
                System.Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                double result = wine - Z;
                result = Math.Ceiling(result);
                double literPerPerson = result / numberOfWorkers;
                literPerPerson = Math.Ceiling(literPerPerson);
                System.Console.WriteLine($"{result} liters left -> {literPerPerson} liters per person.");

            }else
            {
                double result = wine - Z;
                result = Math.Abs(result);
                result = Math.Floor(result);
                System.Console.WriteLine($"It will be a tough winter! More {result} liters wine needed.");
            }
            

        }
    }
}