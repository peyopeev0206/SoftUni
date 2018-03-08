namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class LongerLine
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(System.Console.ReadLine());
            double y1 = double.Parse(System.Console.ReadLine());
            double x2 = double.Parse(System.Console.ReadLine());
            double y2 = double.Parse(System.Console.ReadLine());
            double x3 = double.Parse(System.Console.ReadLine());
            double y3 = double.Parse(System.Console.ReadLine());
            double x4 = double.Parse(System.Console.ReadLine());
            double y4 = double.Parse(System.Console.ReadLine());
    
            CalculateAndPrintCloserPoint(x1, y1, x2, y2, x3, y3, x4, y4);
        }
 
        static void CalculateAndPrintCloserPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstLineLen = System.Math.Sqrt(System.Math.Pow((x2 - x1), 2) + System.Math.Pow((y2 - y1), 2));
            double secondLineLen = System.Math.Sqrt(System.Math.Pow((x4 - x3), 2) + System.Math.Pow((y4 - y3), 2));
    
            if (firstLineLen >= secondLineLen)
            {
                if (chechCloserPoint(x1, y1, x2, y2))
                {
                    System.Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    System.Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (chechCloserPoint(x3, y3, x4, y4))
                {
                    System.Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    System.Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static bool chechCloserPoint(double x1, double y1, double x2, double y2)
        {
            double firstPointLine = System.Math.Sqrt(x1 * x1 + y1 * y1);
            double secondPointLine = System.Math.Sqrt(x2 * x2 + y2 * y2);
            bool isFirstCloser = true;
            if (firstPointLine<=secondPointLine)
            {
                isFirstCloser = true;
            }
            else
            {
                isFirstCloser = false;
            }
            return isFirstCloser;
        }
    }
}