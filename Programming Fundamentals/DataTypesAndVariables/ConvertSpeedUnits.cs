namespace DataTypesAndVariables
{
    public class ConvertSpeedUnits
    {
        public static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(System.Console.ReadLine());
            float h = float.Parse(System.Console.ReadLine());
            float m = float.Parse(System.Console.ReadLine());
            float s = float.Parse(System.Console.ReadLine());
            float hourTime = h + m / 60.0f + s / 3600.0f;

            System.Console.WriteLine(((distanceInMeters / 1000.0f) / hourTime)/3.6f);
            System.Console.WriteLine((distanceInMeters / 1000.0f) / hourTime);
            System.Console.WriteLine((distanceInMeters / 1609.0f) / hourTime);
        }
    }
}