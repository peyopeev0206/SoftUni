namespace DataTypesAndVariables
{
    public class PrintPartOfTheASCIITable
    {
        public static void Main(string[] args)
        {
            int startTheASCII = int.Parse(System.Console.ReadLine());
            int endTheASCII = int.Parse(System.Console.ReadLine());

            for (int i = startTheASCII; i <= endTheASCII; i++)
            {
                System.Console.Write($"{(char)i} ");
            }
        }
    }
}