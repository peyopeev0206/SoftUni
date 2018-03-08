using System;
using System.Globalization;
namespace exercise{
    class exercise{
        static void Main(){
           int n = int.Parse(Console.ReadLine());
           double liters = 0.0;
           double degrees = 0.0;
           double smes = 0.0;
           double totaLiters = 0.0;
           double totalDegrees = 0.0;
           for (int i = 0; i < n; i++)
           {
               liters = double.Parse(Console.ReadLine());
               totaLiters+=liters;
               degrees = double.Parse(Console.ReadLine());
               smes+=liters * degrees;
           }
           System.Console.WriteLine("Liter: {0:f2}",totaLiters);
           totalDegrees = smes/totaLiters;
           System.Console.WriteLine("Degrees: {0:f2}",totalDegrees);
           if (totalDegrees<38)
           {
               System.Console.WriteLine("Not good, you should baking!");
           }else if (totalDegrees >= 38 && totalDegrees <= 42)
           {
               System.Console.WriteLine("Super!");
           }else if (totalDegrees >42)
           {
               System.Console.WriteLine("Dilution with distilled water!");
           }
        }
    }
}