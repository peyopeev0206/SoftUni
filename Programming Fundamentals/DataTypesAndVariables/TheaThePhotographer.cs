namespace DataTypesAndVariables
{
    public class TheaThePhotographer
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(System.Console.ReadLine());
            int FT = int.Parse(System.Console.ReadLine());
            int FF = int.Parse(System.Console.ReadLine());
            int UT = int.Parse(System.Console.ReadLine());   

            double filteredPicture = System.Math.Ceiling(N * (FF / 100.0));
            double totalPicturesInTime = (double)N*FT;
            double filteredPictureInTime = (double)filteredPicture * UT;
            double totalTime = (double)(totalPicturesInTime+filteredPictureInTime);
            System.Console.WriteLine(System.TimeSpan.FromSeconds(totalTime).ToString(@"d\:hh\:mm\:ss"));
        }
    }
}