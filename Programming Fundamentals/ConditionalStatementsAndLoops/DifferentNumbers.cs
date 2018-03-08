using System;
					
public class DifferentNumbers
{
	public static void Main()
	{
        	int a = int.Parse(Console.ReadLine());
        	int b = int.Parse(Console.ReadLine());
		int br=0;
		for (int i = a; i < b; i++)
		{
			for (int q = a; q < b; q++)
			{
				for (int w = a; w < b; w++)
				{
					for (int r = a; r < b; r++)
					{
						for (int t = a; t <= b; t++)
						{
							if (a<=i && i<q && q<w && w<r && r<=t && t<=b && r!=t)
							{
								System.Console.WriteLine($"{i} {q} {w} {r} {t}");
								br++;		
							}
							
						}
					}
				}
			}	
		}
		if (br==0)
		{
			System.Console.WriteLine("No");
		}
	}
}