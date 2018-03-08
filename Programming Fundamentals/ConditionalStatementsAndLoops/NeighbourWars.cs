using System;
namespace ConditionalStatementsAndLoopsHomework
{
    public class NeighbourWars
    {
        public static void Main(string[] args)
        {
            int damageOfPesho = int.Parse(Console.ReadLine());
            int damageOfGosho = int.Parse(Console.ReadLine());

            string PeshoAsString = "Pesho";
            string GoshoAsString = "Gosho";
            string atackOfPesho = "Roundhouse kick";
            string atackOfGosho = "Thunderous fist";

            int restDamageofPesho = 100;
            int restDamageOfGosho = 100;

            for (int i = 1; i < 100; i++)
            {
                if (i%2==0)
                {
                    restDamageofPesho -= damageOfGosho;
                    if (restDamageofPesho <= 0 && restDamageOfGosho > 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {restDamageofPesho} health.");
                }
                else if (i%2==1)
                {
                    restDamageOfGosho -= damageOfPesho;
                    if (restDamageOfGosho <= 0 && restDamageofPesho > 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {restDamageOfGosho} health.");
                }
                if (i%3==0)
                {
                    restDamageOfGosho += 10;
                    restDamageofPesho += 10;
                }
            }
        }
    }
}