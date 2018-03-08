using System;
					
public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		System.Console.WriteLine("|{0}|",new string('-',((n+1)*2)-2));
		System.Console.WriteLine("|{0}|",new string('*',((n+1)*2)-2));
		System.Console.WriteLine("|{0}|",new string('-',((n+1)*2)-2));
		int wave = 2;
		int dashesh = n-1;
		for (int i = 0; i < n-1; i++,wave+=2,dashesh--)
		{
			System.Console.WriteLine("|{0}{1}{0}|",new string('-',dashesh),new string('~',wave));
		}
		
			wave-=2;
			dashesh++;
		for (int i = 0; i < n-2; i++)
		{	
			wave-=2;
			dashesh++;
			System.Console.WriteLine("|{0}{1}{0}|",new string('-',dashesh),new string('~',wave));
		}

		System.Console.WriteLine("\\{0}\\",new string('.',((n+1)*2)-1));
		dashesh = 1;
		for (int i = 0; i < n; i++,dashesh++)
		{
			if (n % 2 ==0)
			{
				if (n/2==i+1)
				{
					System.Console.WriteLine("{0}\\{1}MERRY{1}\\",
						new string('-',dashesh),new string('.',n-2));
				}else if (((n/2)+1)==i)
				{
					System.Console.WriteLine("{0}\\{1}X-MAS{1}\\",
						new string('-',dashesh),new string('.',n-2));
				}else
				{
					System.Console.WriteLine("{0}\\{1}\\",new string('-',dashesh),new string('.',((n+1)*2)-1));
				}
			}else
			{
				if (n/2==i+1)
				{
					System.Console.WriteLine("{0}\\{1}MERRY{1}\\",
						new string('-',dashesh),new string('.',n-2));
				}else if (((n/2)+1)==i)
				{
					System.Console.WriteLine("{0}\\{1}X-MAS{1}\\",
						new string('-',dashesh),new string('.',n-2));
				}else
				{
					System.Console.WriteLine("{0}\\{1}\\",new string('-',dashesh),new string('.',((n+1)*2)-1));
				}
			}
		}
		System.Console.WriteLine("{0}\\{1}\\",new string('-',dashesh),new string('.',((n+1)*2)-1));
		dashesh++;
		System.Console.WriteLine("{0}\\{1})",new string('-',dashesh),new string('_',((n+1)*2)-1));
	}
}