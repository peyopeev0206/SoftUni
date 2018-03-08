using System.Numerics;
namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class FactorialTrailingZeroes
    {
        public static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(System.Console.ReadLine());
            System.Console.WriteLine(FactorialRecursion(n).ToString());
        }
        static BigInteger FactorialRecursion(BigInteger i)
        {
            if (i <= 1)
                return 1;
            return i * FactorialRecursion(i - 1);
        }

        static int CoutTrailingZeroes()
        {
            return 0;
        }
    }
}