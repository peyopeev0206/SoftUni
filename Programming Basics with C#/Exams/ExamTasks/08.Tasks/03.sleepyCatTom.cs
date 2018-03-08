using System;
namespace sleepyCatTom
{
    class sleepyCatTom
    {
        static void Main(string[] args)
        {
            int numberFreeDays = int.Parse(Console.ReadLine());

            int breakDaysInMinutes = numberFreeDays * 127;
            int workdDays = 365 - numberFreeDays;
            int workdDaysInMinutes = workdDays * 63;
            int realTimeForPlay = breakDaysInMinutes + workdDaysInMinutes;
            int difference, hours, minutes = 0;
            if (realTimeForPlay < 30000)
            {
                System.Console.WriteLine("Tom sleeps well");

                difference = realTimeForPlay - 30000;
                hours = difference / 60;
                minutes = difference - hours * 60;
                System.Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes less for play");
            }else
            {
                System.Console.WriteLine("Tom will run away");
                difference = realTimeForPlay - 30000;
                hours = difference / 60;
                minutes = difference - hours * 60;
                System.Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes more for play");
            }

           

        }
    }
}