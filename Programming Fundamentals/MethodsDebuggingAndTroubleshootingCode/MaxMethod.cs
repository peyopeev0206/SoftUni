namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class MaxMethod
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(System.Console.ReadLine());
            int secondNumber = int.Parse(System.Console.ReadLine());
            int thirdNumber = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(System.Math.Max(GetMax(firstNumber,secondNumber),thirdNumber));
        }

        static int GetMax(int first, int second)
        {
            if (first>second)
            {
                return first;
            }else
            {
                return second;
            }
        }
    }
}