using System;
using System.Globalization;
using System.Numerics;
namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersRecived = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < ordersRecived; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(),
                                                         "d/M/yyyy",
                                                         CultureInfo.InvariantCulture
                                                         );
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMount = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                totalPrice +=(daysInMount * capsulesCount) * pricePerCapsule;
                Console.WriteLine("The price for the coffee is: ${0:F2}",(daysInMount * capsulesCount) * pricePerCapsule);
            }
            Console.WriteLine("Total: ${0:F2}",totalPrice);
        }
    }
}
