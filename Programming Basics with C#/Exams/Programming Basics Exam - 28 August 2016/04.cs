using System;
class Program
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());

        int doctors = 7;
        int treated = 0;
        int untreated = 0;

        for (int i = 1; i <= period; i++)
        {
            int patients = int.Parse(Console.ReadLine());
           
            if (i % 3 == 0)
            {
                if (untreated > treated)
                {
                    doctors++;
                }
            }
            if (doctors >= patients)
            {
                treated = treated + patients;
            }
            else 
            {
                untreated = untreated + (patients - doctors);
                treated = treated + doctors;
            }
        }
        Console.WriteLine("Treated patients: {0}.", treated);
        Console.WriteLine("Untreated patients: {0}.", untreated);
    }
}