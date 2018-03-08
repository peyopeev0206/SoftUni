using System;

public class wordInPlural
{
    public static void Main()
    {
        string noun = Console.ReadLine();
        
        if (noun.Substring(noun.Length - 1)=="y")
        {
            noun=noun.Substring(0,noun.Length - 1);
            noun+="ies";
        }else if (noun.Substring(noun.Length - 1)=="o" ||
                    noun.Substring(noun.Length - 1)=="s" ||
                    noun.Substring(noun.Length - 1)=="x" ||
                    noun.Substring(noun.Length - 1)=="z")
        {
            noun+="es";
        }else if (noun.Substring(noun.Length - 2)=="ch" || noun.Substring(noun.Length - 2)=="sh")
        {
            noun+="es";
        }else
        {
            noun+="s";
        }

        System.Console.WriteLine(noun);
    }
}