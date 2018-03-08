namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class HelloName
    {
        public static void Main(string[] args)
        {
            helloNameMethod(System.Console.ReadLine());
        }

        static void helloNameMethod(string name)
        {
            System.Console.WriteLine($"Hello, {name}!");
        }
    }
}