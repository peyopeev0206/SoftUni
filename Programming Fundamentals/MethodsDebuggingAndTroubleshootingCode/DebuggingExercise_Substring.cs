using System;
namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class DebuggingExercise_Substring
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int length = jump + 1;
                    string matchedString;
                    if (i + length <= text.Length)
                    {
                        matchedString = text.Substring(i, length);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }   
    }
}