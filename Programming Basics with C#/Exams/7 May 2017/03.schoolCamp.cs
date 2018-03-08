using System;

namespace schoolCamp
{
    class schoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string typeOfGroup = Console.ReadLine().ToLower();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());

            string typeOfSport = "";
            double priceForNight = 0.0;
            double totalPriceForTrip = 0.0;
            double discount = 0.0;
            double finalPrice = 0.0;

            if (season == "winter")
            {
                if (typeOfGroup == "girls")
                {
                    priceForNight = 9.60;
                    typeOfSport = "Gymnastics";
                }else if (typeOfGroup == "boys")
                {
                    priceForNight = 9.60;
                    typeOfSport = "Judo";
                }else if (typeOfGroup == "mixed")
                {
                    priceForNight = 10;
                    typeOfSport = "Ski";
                }
                
            }else  if (season == "spring")
            {
                if (typeOfGroup == "girls")
                {
                    priceForNight = 7.20;
                    typeOfSport = "Athletics";
                }else if (typeOfGroup == "boys")
                {
                    priceForNight = 7.20;
                    typeOfSport = "Tennis";
                }else if (typeOfGroup == "mixed")
                {
                    priceForNight = 9.50;
                    typeOfSport = "Cycling";
                }
            }else  if (season == "summer")
            {
                if (typeOfGroup == "girls")
                {
                    priceForNight = 15;
                    typeOfSport = "Volleyball";
                }else if (typeOfGroup == "boys")
                {
                    priceForNight = 15;
                    typeOfSport = "Football";
                }else if (typeOfGroup == "mixed")
                {
                    priceForNight = 20;
                    typeOfSport = "Swimming";
                }
            }
            
            totalPriceForTrip = numberOfStudents * priceForNight * numberOfNights;

            if (numberOfStudents >= 50)
            {
                discount = 0.5*totalPriceForTrip;;
            }else if (numberOfStudents >= 20)
            {
                discount = 0.15*totalPriceForTrip;
                
            }else if (numberOfStudents >= 10)
            {
                discount = 0.05*totalPriceForTrip;;
            }

            finalPrice = totalPriceForTrip - discount;
            System.Console.WriteLine("{0} {1:0.00} lv.",typeOfSport,finalPrice);
        }
    }
}