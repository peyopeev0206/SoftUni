namespace DataTypesAndVariables
{
    public class IntegerToHexAndBinary
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(System.Convert.ToString(n, 16).ToUpper());
            System.Console.WriteLine(System.Convert.ToString(n, 2));

        }
    }
}