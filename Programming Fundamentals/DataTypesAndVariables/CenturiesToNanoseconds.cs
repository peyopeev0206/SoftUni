namespace DataTypesAndVariables
{
    public class CenturiesToNanoseconds
    {
        public static void Main(string[] args)
        {
            int centuries = int.Parse(System.Console.ReadLine());
            int year = centuries * 100;
            int days = (int)(year * 365.2422M);
            int hours = 24 * days;
            decimal minutes = 60M * hours;
            decimal seconds = 60M * minutes;
            decimal milliseconds = 1000M * seconds;
            decimal microseconds = 1000M * milliseconds;
            decimal nanoseconds = 1000M * microseconds;
            System.Console.Write($"{centuries} centuries = ");//9
            System.Console.Write($"{year} years = ");//900
            System.Console.Write($"{days} days = ");//328717
            System.Console.Write($"{hours} hours = ");//7889208
            System.Console.Write($"{minutes} minutes = ");//473352480
            System.Console.Write($"{seconds} seconds = ");//28401148800
            System.Console.Write($"{milliseconds} milliseconds = ");//28401148800000
            System.Console.Write($"{microseconds} microseconds = ");//28401148800000000
            System.Console.Write($"{nanoseconds} nanoseconds");
        
        }
    }
}