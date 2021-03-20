using System;
using System.Collections.Generic;

namespace Vendor_Machine
{
    public class Program 
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> listProducts = new Dictionary<int, string>();
            listProducts.Add(20, "Nickles");
            listProducts.Add(10, "Dimes");
            listProducts.Add(4, "Quarters");

            Console.WriteLine("Please enter cost!");
            int cost = Convert.ToInt32(Console.ReadLine());
            if(listProducts.ContainsKey(cost))
            {
                Console.WriteLine(listProducts[cost].ToString());
            }
            else
            {
                Console.WriteLine("Invalid Coin, Rejected");
            }

            Console.ReadLine();
        }
    }
}
