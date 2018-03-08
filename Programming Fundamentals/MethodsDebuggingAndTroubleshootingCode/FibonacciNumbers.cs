namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            System.Console.Write(Fib(n));
        }

        static int Fib(int n)
        {
            if (n < 2)
            {
                return 1;
            }
 
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}