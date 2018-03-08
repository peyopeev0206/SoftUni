namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class GeometryCalculator
    {
        public static void Main(string[] args)
        {
            string figureType = System.Console.ReadLine().ToLower();

            switch (figureType)
            {
                case "triangle":
                    double sideofTriangle = double.Parse(System.Console.ReadLine());
                    double heightOfTriangle = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("{0:f2}",(sideofTriangle*heightOfTriangle)/2);
                    break;
                case "square":
                    double sideOfSquare = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("{0:f2}",System.Math.Pow(sideOfSquare,2));
                    break;
                case "rectangle":
                    double widthOfRectangle = double.Parse(System.Console.ReadLine());
                    double heightOfRectangle = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("{0:f2}",widthOfRectangle*heightOfRectangle);
                    break;
                case "circle":
                    double radiusOfCircle = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("{0:f2}",System.Math.PI*System.Math.Pow(radiusOfCircle,2));
                    break;
                default:
                    break;
            }
        }
    }
}