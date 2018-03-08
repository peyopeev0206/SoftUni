namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class EnglishNameOfTheLastDigit
    {
        public static void Main(string[] args)
        {
            long input = long.Parse(System.Console.ReadLine());
            System.Console.WriteLine(returnNameOfANumber(System.Math.Abs(input % 10)));
        }

        static string returnNameOfANumber(long lastDigit)
        {
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return null;
            }
        }
    }
}