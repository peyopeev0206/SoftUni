using System.Numerics;
namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class Factorial
    {
        public static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(System.Console.ReadLine());
            System.Console.WriteLine(GetTrailingZeroes(FactorialRecursion(n)));
        }
        static BigInteger FactorialRecursion(BigInteger num)
        {
            if (num <= 1)
                return 1;
            return num * FactorialRecursion(num - 1);
        }

        static BigInteger GetTrailingZeroes(BigInteger num)
        {
 
            BigInteger timesZero = 0;
            while (num % 10 == 0)
            {
                num = num / 10;
                timesZero++;
            }
            return timesZero;
        }
    }
}