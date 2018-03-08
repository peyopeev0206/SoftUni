namespace DataTypesAndVariables
{
    public class DifferentIntegersSize
    {
        public static void Main(string[] args)
        {
            string input = System.Console.ReadLine();
            if (long.TryParse(input,out long outlong))
            {
                System.Console.WriteLine($"{input} can fit in:");
                if (sbyte.TryParse(input,out sbyte noutSByte))
                {
                    System.Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(input,out byte noutByte))
                {
                    System.Console.WriteLine("* byte");
                }
                if (short.TryParse(input,out short noutShort))
                {
                    System.Console.WriteLine("* short");
                }
                if (ushort.TryParse(input,out ushort noutUShort))
                {
                    System.Console.WriteLine("* ushort");
                }
                if (int.TryParse(input,out int noutInt))
                {
                    System.Console.WriteLine("* int");
                }
                if (uint.TryParse(input,out uint noutUInt))
                {
                    System.Console.WriteLine("* uint");
                }

                    System.Console.WriteLine("* long");
            }else
            {
                System.Console.WriteLine($"{input} can't fit in any type");
            }
            
        }
    }
}