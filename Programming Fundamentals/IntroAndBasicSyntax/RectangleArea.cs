using System;
					
public class RectangleArea
{
	public static void Main()
	{
		float width = float.Parse(Console.ReadLine());
		float height = float.Parse(Console.ReadLine());

		System.Console.WriteLine("{0:0.00}",width*height);
	}
}