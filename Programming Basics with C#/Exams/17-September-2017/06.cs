using System;
using System.Globalization;
namespace exercise{
    class exercise{
        static void Main(){
           int M = int.Parse(Console.ReadLine());
           int a ,A = 0;
           int b ,B = 0;
           int c ,C = 0;
           int d ,D = 0;
           int br= 0;
           for (int i = 1; i <= 9; i++)
           {
               a=i;
              
               for (int j = 1; j <= 9; j++)
               {
                   b=j;
                   
                   for (int q = 1; q <= 9; q++)
                   {
                       c=q;
                       for (int w = 1; w <= 9; w++)
                       {
                           d=w;
                          if (a<b)
                          {
                            if(c>d)
                            {
                                if ((a*b+c*d)==M)
                                {
                                    System.Console.Write("{0}{1}{2}{3} ",a,b,c,d);
                                    br++;
                                    if(br==4)
                                    {
                                         A=a;
                                         B=b;
                                         C=c;
                                         D=d;
                                    }
                                }
                            }   
                          }
                          
                       }
                   }
               }

           }
           System.Console.WriteLine();
               
                if (br>=4)
            {
                Console.WriteLine($"Password: {A}{B}{C}{D}");
            }
            else
            {
                Console.WriteLine("No!");
            }
         
        }
    }
}