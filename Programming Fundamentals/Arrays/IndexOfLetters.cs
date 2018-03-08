using System;
using System.Linq;
namespace Arrays
{
    public class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            int pos = 0;
            for (char alpha = 'a'; alpha <= 'z'; alpha++,pos++)
            {
                alphabet[pos]=alpha;
            }
            string text = Console.ReadLine();
            char[] charText = text.ToCharArray();

            for (int i = 0; i < charText.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (charText[i]==alphabet[j])
                    {
                        System.Console.WriteLine("{0} -> {1}",charText[i],j);
                    }
                }
                
            }
        }
    }
}
