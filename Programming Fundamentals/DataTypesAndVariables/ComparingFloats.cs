namespace DataTypesAndVariables
{
    public class ComparingFloats
    {
        public static void Main(string[] args)
        {
            double firstInput = double.Parse(System.Console.ReadLine());
            double secondInput = double.Parse(System.Console.ReadLine());
            double eps = 0.000001f;
            double result = System.Math.Abs(firstInput-secondInput);

            if (result>eps)
            {
                System.Console.WriteLine("False");
            }else
            {
                System.Console.WriteLine("True");
            }
        }
    }
}