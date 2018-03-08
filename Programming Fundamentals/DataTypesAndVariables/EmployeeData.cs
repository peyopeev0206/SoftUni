namespace DataTypesAndVariables
{
    public class EmployeeData
    {
        public static void Main(string[] args)
        {
            string firstName = System.Console.ReadLine();
            System.Console.WriteLine($"First name: {firstName}");

            string lastName = System.Console.ReadLine();
            System.Console.WriteLine($"Last name: {lastName}");

            sbyte age = sbyte.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Age: {age}");

            char gender = char.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Gender: {gender}");

            long personalIDNumber = long.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Personal ID: {personalIDNumber}");

            uint uniqueEmpNumber = uint.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Unique Employee number: {uniqueEmpNumber}");
        }
    }
}