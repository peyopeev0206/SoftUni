using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace StringsAndTextProcessing
{
    public class ConvertfromBase10toBaseN
    {
        public static void Main(string[] args)
        {
            List<BigInteger> input = Console.ReadLine()
                                .Split()
                                .Select(x => BigInteger.Parse(x))
                                .ToList();
            
            List<BigInteger> result = new List<BigInteger>();
            BigInteger baseN = input[0];
            BigInteger numberToConvert = input[1];

            while(numberToConvert != 0)
            {
                result.Add(numberToConvert % baseN);
                numberToConvert /=baseN;
            }   
            result.Reverse();
            System.Console.WriteLine(string.Join("",result));

        }
    }
}