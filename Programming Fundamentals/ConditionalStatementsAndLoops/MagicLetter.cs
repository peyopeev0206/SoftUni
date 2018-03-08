using System;
namespace ConditionalStatementsAndLoopsHomework
{
    public class MagicLetter
    {
        public static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetterNotPrint = char.Parse(Console.ReadLine());


            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char w = firstLetter; w <= secondLetter; w++)
                {
                    for (char e = firstLetter; e <= secondLetter; e++)
                    {
                        if (i!=thirdLetterNotPrint && w!=thirdLetterNotPrint && e!=thirdLetterNotPrint)
                        {
                            System.Console.Write($"{i}{w}{e} ");
                        }
                    }
                }
            }
        }
    }
}