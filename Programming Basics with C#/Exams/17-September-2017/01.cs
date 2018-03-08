using System;
using System.Globalization;
namespace exercise{
    class exercise{
        static void Main(){
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double totalLiters = volume * 0.001;
            procent = procent * 0.01;
            System.Console.WriteLine("{0:0.000}",totalLiters*(1-procent));
        }
    }
}