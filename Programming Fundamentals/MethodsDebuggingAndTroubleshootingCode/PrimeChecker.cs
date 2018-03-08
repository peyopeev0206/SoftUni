namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class PrimeChecker
    {
        public static void Main(string[] args)
        {
            long inputNumber = long.Parse(System.Console.ReadLine());
            System.Console.WriteLine(IsPrime(inputNumber));
        }

        static bool IsPrime(long number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            int root = (int)System.Math.Sqrt((double)number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
