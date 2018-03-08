using System;
namespace onTimeForExam
{
    class onTimeForExam
    {
        static void Main(string[] args)
        {
            
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int studentsH = int.Parse(Console.ReadLine());
            int studentsM = int.Parse(Console.ReadLine());
            
            examM+=examH * 60;
            studentsM+=studentsH * 60;
            int difference = examM - studentsM; 

            if(difference < 0){
                System.Console.WriteLine("Late");

                if(Math.Abs(difference)<60){
                    System.Console.WriteLine("{0} minutes after the start",Math.Abs(difference));
                }else {
                    System.Console.WriteLine("{0}:{1:00} hours after the start",Math.Abs(difference/60), Math.Abs(difference%60));
                }

            }else if(difference>0){
                if (difference<=30)
                {
                    System.Console.WriteLine("On time");
                    
                }else{
                    System.Console.WriteLine("Early");
                 }

                if(difference<60){
                    System.Console.WriteLine("{0} minutes before the start",difference);
                }else{
                    System.Console.WriteLine("{0}:{1:00} hours before the start",difference/60, difference%60);
                }
            }else {
                System.Console.WriteLine("On time");
            }

        }
    }
}