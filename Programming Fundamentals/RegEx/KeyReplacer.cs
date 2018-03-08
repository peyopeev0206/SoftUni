using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace RegEx
{
    public class KeyReplacer
    {
        public static void Main(string[] args)
        {
            string keyInput = Console.ReadLine();
            string textInput = Console.ReadLine();
            
            string patternKeys = @"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)$";
            var matchKeys = Regex.Match(keyInput, patternKeys);

            if (matchKeys.Success)
            {
                var startKey = matchKeys.Groups["startKey"];
                var endKey = matchKeys.Groups["endKey"];
                var patternText = $@"{startKey}(?<word>.*?){endKey}";
                var matchText = Regex.Matches(textInput, patternText);
                var result = new StringBuilder();

                foreach (Match match in matchText)
                {
                    result.Append(match.Groups["word"].Value);
                }
                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}