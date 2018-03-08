namespace DataTypesAndVariables
{
    public class FastPrimeCheckerRefactor
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(System.Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {    
                System.Console.WriteLine($"{i} -> {IsPrime(i)}");
            }
        }

         public static bool IsPrime(int number)
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