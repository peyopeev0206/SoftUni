using System;
namespace Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("+{0}+{1}", new string('~', n - 2),new string('.', 2 * n + 1));
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",new string('.', i) , new string('~', n - 2) , new string('.', 2 * n - i));
            }
            for (int j = 0; j < 2 * n + 1; j++)
            {
                Console.WriteLine("{0}\\{1}|{2}|",new string('.', j) , new string('.', 2 * n - j) , new string('~', n - 2));
            }
            Console.WriteLine("{0}+{1}+",new string('.', 2 * n + 1) ,new string('~', n - 2));
            
        }
    }
}