using System;
using System.Globalization;
namespace exercise{
    class exercise{
        static void Main(){
           string termContract = Console.ReadLine();
           string typeContract = Console.ReadLine();
           string internet = Console.ReadLine();
           int numbersOFMounts = int.Parse(Console.ReadLine());
           double peyment=0.0;

           if (termContract == "one")
           {
                if (typeContract == "Small") peyment = 9.98;
                else if (typeContract == "Middle") peyment = 18.99;
                else if (typeContract == "Large") peyment = 25.98;
                else if (typeContract == "ExtraLarge") peyment = 35.99;
           }else if (termContract == "two")
           {
               if (typeContract == "Small") peyment = 8.58;
                else if (typeContract == "Middle") peyment = 17.09;
                else if (typeContract == "Large") peyment = 23.59;
                else if (typeContract == "ExtraLarge") peyment = 31.79;
           }
           
           if (internet == "yes")
           {
                if (peyment <= 10.00) peyment += 5.50;
                else if (peyment > 10.00 && peyment <= 30.00) peyment += 4.35;
                else if (peyment > 30.00) peyment += 3.85;
                
                
           }
           if (termContract=="two")
                {
                     peyment *= 1 - 0.0375;
                }
           System.Console.WriteLine("{0:f2} lv.",peyment * numbersOFMounts);
        }
    }
}