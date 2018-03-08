
namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class CenterPoints
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(System.Console.ReadLine());
            double y1 = double.Parse(System.Console.ReadLine());
            double x2 = double.Parse(System.Console.ReadLine());
            double y2 = double.Parse(System.Console.ReadLine());


            if (CalculateDistance(x1, y1) >= CalculateDistance(x2, y2))
            {
                System.Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                System.Console.WriteLine($"({x1}, {y1})");
            }

    }
        public static double CalculateDistance(double x, double y)
        {
            double distance = System.Math.Sqrt(System.Math.Pow(x, 2) + System.Math.Pow(y, 2));
            return distance;
        }
    }
}
