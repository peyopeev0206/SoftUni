namespace DataTypesAndVariables
{
    public class StringsAndObjects
    {
        public static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWordObject = hello + " " + world;
            string helloWordToString = (string) helloWordObject;
            System.Console.WriteLine(helloWordToString);
        }
    }
}