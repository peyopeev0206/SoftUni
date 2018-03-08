using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthMarathonInDay = int.Parse(Console.ReadLine()); //int
            var numberOfParticipateRunners = long.Parse(Console.ReadLine()); //long
            var averageNumberOfLapsPerRunner = int.Parse(Console.ReadLine()); //int
            var lenghtOfTrack = long.Parse(Console.ReadLine()); //long
            var capacotyOfTrack = int.Parse(Console.ReadLine()); //int
            var amountOfMonetDonatedPerKM = double.Parse(Console.ReadLine()); //double

            var maximumRunners = capacotyOfTrack * lengthMarathonInDay;
            numberOfParticipateRunners = Math.Min(maximumRunners, numberOfParticipateRunners);

            var totalMetarsInKM = (numberOfParticipateRunners * averageNumberOfLapsPerRunner * lenghtOfTrack) /1000;

            Console.WriteLine("Money raised: {0:0.00}",totalMetarsInKM * amountOfMonetDonatedPerKM);
        }
    }
}