using System;
using System.Globalization;
namespace exercise{
    class exercise{
        static void Main(){
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother =  double.Parse(Console.ReadLine());
            double thirtBrother =  double.Parse(Console.ReadLine());
            double fatherFishing =  double.Parse(Console.ReadLine());

            double totalTime = 1/( 1/firstBrother+ 1/secondBrother+ 1/thirtBrother);
            double totalTimeWithBreaks = (totalTime * 0.15)+totalTime;
                System.Console.WriteLine("Cleaning time: {0:f2}",totalTimeWithBreaks);
            double timeLeft = fatherFishing - totalTimeWithBreaks;
            if (timeLeft>0)
            {
                System.Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.",Math.Floor(timeLeft));
            }else
            {
                System.Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.",Math.Ceiling(Math.Abs(timeLeft)));
            }
        }
    }
}