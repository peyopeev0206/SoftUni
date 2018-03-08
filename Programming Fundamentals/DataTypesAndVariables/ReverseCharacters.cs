namespace DataTypesAndVariables
{
    public class ReverseCharacters
    {
        public static void Main(string[] args)
        {
            char firstChar = char.Parse(System.Console.ReadLine());
            char secondChar = char.Parse(System.Console.ReadLine());
            char thurthChar = char.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"{thurthChar}{secondChar}{firstChar}");
        }
    }
}