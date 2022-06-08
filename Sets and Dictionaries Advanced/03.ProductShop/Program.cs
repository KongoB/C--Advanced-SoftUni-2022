using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();


            string[] input = Console.ReadLine().Split(", ");


            while (input[0] != "Revision")
            {

                string shopName = input[0];
                string productName = input[1];
                double productPrice = double.Parse(input[2]);

                if (!shops.ContainsKey(shopName))
                {

                    shops.Add(shopName, new Dictionary<string, double>());

                }

                if (!shops[shopName].ContainsKey(productName))
                {
                    shops[shopName].Add(productName, productPrice);
                }


                input = Console.ReadLine().Split(", ");
            }

            shops = shops.OrderBy(s => s.Key).ToDictionary(k => k.Key, v => v.Value);


            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }

            }


        }
    }
}
