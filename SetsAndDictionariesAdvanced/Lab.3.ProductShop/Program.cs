using System;
using System.Collections.Generic;

namespace Lab._3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> productShop = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "Revision")
            {
                string store = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!productShop.ContainsKey(store))
                {
                    productShop.Add(store, new Dictionary<string, double>());

                    if (!productShop[store].ContainsKey(product))
                    {
                        productShop[store].Add(product, price);
                    }
                    else
                    {
                        productShop[store][product] = price;
                    }
                }
                else
                {
                    if (!productShop[store].ContainsKey(product))
                    {
                        productShop[store].Add(product, price);
                    }
                    else
                    {
                        productShop[store][product] = price;
                    }
                }

                input = Console.ReadLine().Split(", ");
            }

            foreach (var store in productShop)
            {
                Console.WriteLine($"{store.Key}->");
                
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
