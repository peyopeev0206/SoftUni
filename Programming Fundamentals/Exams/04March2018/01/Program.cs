using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal amountOfMoneyIvanChoHas = decimal.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            decimal priceOfLightsabersForSingleSabre = decimal.Parse(Console.ReadLine());
            decimal priceOfRobesForSingleRobe = decimal.Parse(Console.ReadLine());
            decimal priceOfBeltsForSingleBelt = decimal.Parse(Console.ReadLine());
            int freeBelts = countOfStudents / 6;

            decimal totalLightsabres = (int)Math.Ceiling((0.1 * countOfStudents) + countOfStudents);

            decimal sabrePriceTotal = priceOfLightsabersForSingleSabre * totalLightsabres;
            decimal robePriceTotal = priceOfRobesForSingleRobe * (countOfStudents);
            decimal beltPrice = priceOfBeltsForSingleBelt * (countOfStudents - freeBelts);

            decimal totalPrice = sabrePriceTotal + robePriceTotal + beltPrice;

            if (amountOfMoneyIvanChoHas >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }else
            {
                Console.WriteLine("Ivan Cho will need {0:F2}lv more.",totalPrice-amountOfMoneyIvanChoHas);
            }
        }
    }
}
