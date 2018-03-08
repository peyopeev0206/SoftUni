using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace divicing
{
    class divicing
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
 
 
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
 
                if (number % 2 == 0)
                {
                    p2++;
                }
                if (number % 3 == 0)
                {
                    p3++;
                }
                if (number % 4 == 0)
                {
                    p4++;
                }
            }
           
            Console.WriteLine("{0,0:F2}%", p2 /count  * 100);
            Console.WriteLine("{0,0:F2}%", p3 /count * 100);
            Console.WriteLine("{0,0:F2}%", p4 /count * 100);
        }                                    
    }
}