namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class NumbersInReversedOrder
    {
        public static void Main(string[] args)
        {
            string input = System.Console.ReadLine();
            System.Console.WriteLine(PrintReverInput(input));
        }

        static string PrintReverInput(string input)
        {
            string reversetInput = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                reversetInput+=input[i];
            }
            return reversetInput;
        }
    }
}