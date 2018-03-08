using System;

namespace numberGenerator
{
    class numberGenerator
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int m = M; m >= 1; m--)
            {
                for (int n = N; n >= 1; n--)
                {
                    for (int l = L; l >= 1; l--)
                    {
                        if (specialNumber<controlNumber)
                        {
                            int number = ((100*m) + (10*n) + l);

                            if (number % 3 ==0)
                            {
                                specialNumber+=5;
                            }else if (number % 10 == 5)
                            {
                                specialNumber -=2;
                            }else if (number % 2 ==0)
                            {
                                specialNumber *= 2;
                            }
                        }else
                        {
                            break;
                        }
                    }
                }
            }
             if (specialNumber >= controlNumber)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
            }else
            {
                Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
            }
        }
    }
}