using System;
using System.Collections.Generic;
using System.Linq;
namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataSets = new Dictionary<string, Dictionary<string, long>>();
            var cacheSets = new Dictionary<string, Dictionary<string, long>>();

            string inputText = string.Empty;


            while ((inputText = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] splitInputText = inputText
                    .Split(new char[] { ' ', '-', '|', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (splitInputText.Length == 1)
                {
                    string dataSet = splitInputText[0];
                    if (cacheSets.ContainsKey(dataSet))
                    {
                        dataSets[dataSet]= new Dictionary<string, long>(cacheSets[dataSet]);
                        cacheSets.Remove(dataSet);
                    }else
                    {
                        dataSets[dataSet] = new Dictionary<string, long>();
                    }
                }else
                {

                    string dataKey = splitInputText[0];
                    long dataSize = long.Parse(splitInputText[1]);
                    string dataSet = splitInputText[2];

                    if (!dataSets.ContainsKey(dataSet))
                    {
                        if (!cacheSets.ContainsKey(dataSet))
                        {
                            cacheSets[dataSet] = new Dictionary<string, long>();
                        }

                        cacheSets[dataSet][dataKey] = dataSize;
                    }else
                    {
                        dataSets[dataSet][dataKey] = dataSize;
                    }
                }
            }

            if (dataSets.Count > 0)
            {
                var result = dataSets
                    .OrderByDescending(x => x.Value.Sum(d => d.Value))
                    .First();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(x => x.Value)}");

                foreach (var data in result.Value)
                {
                    Console.WriteLine("$.{0}",data.Key);
                }
            }
        }
    }
}