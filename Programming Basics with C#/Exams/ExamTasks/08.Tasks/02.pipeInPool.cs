using System;
namespace pipelnPool
{
    class pipelnPool
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double P1Debit = 0;
            double P2Debit = 0;
            double totalPipeDebit = 0;

            P1Debit = P1 * H;
            P2Debit = P2 * H;
            totalPipeDebit = P1Debit + P2Debit;
            int pipe1Percent = (int)(P1Debit * 100 / totalPipeDebit);
            int pipe2Percent = (int)(P2Debit * 100 / totalPipeDebit);
            int totalPercent = (int)(totalPipeDebit * 100 / V);
            double difference = Math.Abs(totalPipeDebit - V);
            if (totalPipeDebit <= V)
            {  
                System.Console.WriteLine($"The pool is {totalPercent:f0}% full. Pipe 1: {pipe1Percent}%. Pipe 2: {pipe2Percent}%.");
            }else
            {
                System.Console.WriteLine($"For {H} hours the pool overflows with {difference:f1} liters.");
            }
           

        }
    }
}