using System;
using System.Collections.Generic;
using System.Linq;
namespace DictionariesLambdaAndLINQ
{
    public class AMinerTask
    {
        public static void Main(string[] args)
        {
            var minerResource = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while(resource!="stop")
            {
                
                int quantity = int.Parse(Console.ReadLine());

                if (!minerResource.ContainsKey(resource))
                {
                    minerResource.Add(resource, 0);
                }

                minerResource[resource] += quantity;
                resource = Console.ReadLine();
            }

            foreach (var item in minerResource)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}