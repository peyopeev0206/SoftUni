namespace DataTypesAndVariables
{
    public class RectangleProperties
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(System.Console.ReadLine());
            double height = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine(2*(width+height));
            System.Console.WriteLine(width*height);
            System.Console.WriteLine(System.Math.Sqrt(System.Math.Pow(width,2)+System.Math.Pow(height,2)));
            
        }
    }
}