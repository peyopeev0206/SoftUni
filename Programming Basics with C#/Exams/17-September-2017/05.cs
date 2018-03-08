using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
    {
        class exercise
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                int width = 3 * n; //3 * 3 = 9
                
                

                string dots = new string('.', (width - 3) / 2);//(9-3)/2 = 
                string dotsTwo = new string('.', (width -3)/2);
                Console.WriteLine($"{dots}.x.{dots}");
                Console.WriteLine($"{dotsTwo}/x\\{dotsTwo}");
                Console.WriteLine($"{dotsTwo}x|x{dotsTwo}");

                for (int i = 0; i < (n + 1) / 2; i++)
                {
                    string cross = new string('x', n + i);
                    string Moredots = new string('.', ((width - 1) / 2) - n - i);
                    Console.WriteLine($"{Moredots}{cross}|{cross}{Moredots}");
                }

                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    string Moredots = new string('.', i);
                    string cross = new string('x', width / 2 - i);
                    Console.WriteLine($"{Moredots}{cross}|{cross}{Moredots}");
                }

                Console.WriteLine($"{dots}/x\\{dots}");
                Console.WriteLine($"{dots}\\x/{dots}");


                for (int i = 0; i < (n + 1) / 2; i++)
                {
                    string cross = new string('x', n + i);
                    string Moredots = new string('.', ((width-1) / 2) - n - i);
                    Console.WriteLine($"{Moredots}{cross}|{cross}{Moredots}");
                }

                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    string Moredots = new string('.', i);
                    string cross = new string('x', width / 2 -i);
                    Console.WriteLine($"{Moredots}{cross}|{cross}{Moredots}");
                }

                Console.WriteLine($"{dotsTwo}x|x{dotsTwo}");
                Console.WriteLine($"{dotsTwo}\\x/{dotsTwo}");
                Console.WriteLine($"{dots}.x.{dots}");
            }
        }
    }