namespace DataTypesAndVariables
{
    public class ExchangeVariableValues
    {
        public static void Main(string[] args)
        {
            int numberOne = int.Parse(System.Console.ReadLine());
            int numberTwo = int.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine("Before:");
            System.Console.WriteLine($"a = {numberOne}");
            System.Console.WriteLine($"b = {numberTwo}");

            int helpSwapNumber = numberOne;
            numberOne=numberTwo;
            numberTwo=helpSwapNumber;
            
            System.Console.WriteLine("After:");
            System.Console.WriteLine($"a = {numberOne}");
            System.Console.WriteLine($"b = {numberTwo}");
        }
    }
}