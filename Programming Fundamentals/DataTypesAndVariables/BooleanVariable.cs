namespace DataTypesAndVariables
{
    public class BooleanVariable
    {
        public static void Main(string[] args)
        {
            string trueOrFalse = System.Console.ReadLine().ToLower();
            if (System.Convert.ToBoolean(trueOrFalse))
            {
                System.Console.WriteLine("Yes");
            }else
            {
                System.Console.WriteLine("No");
            }
            
        }
    }
}