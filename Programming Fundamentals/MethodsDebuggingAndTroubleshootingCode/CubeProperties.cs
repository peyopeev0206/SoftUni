namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class CubeProperties
    {
        public static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(System.Console.ReadLine());
            string parameter = System.Console.ReadLine().ToLower();

            switch (parameter)
            {
                case "face":
                    System.Console.WriteLine("{0:F2}",CalculateFaceCube(sideOfTheCube));
                    break;
                case "space":
                    System.Console.WriteLine("{0:F2}",CalculateSpaceCube(sideOfTheCube));
                    break;
                case "volume":
                    System.Console.WriteLine("{0:F2}",CalculateVolumeCube(sideOfTheCube));
                    break;
                case "area":
                    System.Console.WriteLine("{0:F2}",CalculateAreaCube(sideOfTheCube));
                    break;
                default:
                    break;
            }

        }

        static double CalculateFaceCube(double sideOfTheCube)
        {
            return System.Math.Sqrt(2 * System.Math.Pow(sideOfTheCube,2));
        }
        static double CalculateSpaceCube(double sideOfTheCube)
        {
            return System.Math.Sqrt(3 * System.Math.Pow(sideOfTheCube,2));
        }
        static double CalculateVolumeCube(double sideOfTheCube)
        {
            return System.Math.Pow(sideOfTheCube,3);
        }
        static double CalculateAreaCube(double sideOfTheCube)
        {
            return 6 * System.Math.Pow(sideOfTheCube,2);
        }
    }
}