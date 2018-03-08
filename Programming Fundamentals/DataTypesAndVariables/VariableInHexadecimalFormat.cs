namespace DataTypesAndVariables
{
    public class VariableInHexadecimalFormat
    {
        public static void Main(string[] args)
        {
            string hex = System.Console.ReadLine();
            System.Console.WriteLine(System.Convert.ToInt32(hex, 16));
        }
    }
}