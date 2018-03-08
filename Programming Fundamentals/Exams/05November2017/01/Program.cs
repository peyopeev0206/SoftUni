using System;
using System.Linq;
using System.Numerics;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityToken = int.Parse(Console.ReadLine());

            decimal siteLoss = 0M;
            //string[] websiteName = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] websiteData = Console.ReadLine()
                                              .Split()
                                              .ToArray();
                
                string siteName = websiteData[0];
                long siteVisits = long.Parse(websiteData[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websiteData[2]);

                //websiteName[i] = siteName;
                Console.WriteLine(siteName);
                siteLoss += siteVisits * siteCommercialPricePerVisit; 
            }
            Console.WriteLine($"Total Loss: {siteLoss:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityToken), n)}");
        }
    }
}
