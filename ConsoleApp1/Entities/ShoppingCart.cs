using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class ShoppingCart
    {
        private static List<Products> Products = new();

        public static void AddProduct(Products product)
        {
            Products.Add(product);
        }

        public static void RemoveCart()
        {
            Products.Clear();
        }

        public static void PrintCart()
        {
            Console.WriteLine("Your shopping cart:");
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }

        private static List<Products> Cost = new();

        public static void AddCost(Products Price)
        {
            Cost.Add(Price);
        }

        public static void PrintCost()
        {
            double shoppingCartSum = 0;
            foreach (var price in Products)
            {
                shoppingCartSum = shoppingCartSum + Convert.ToDouble(price.Price);
            }
            Console.WriteLine($"Total cost: {shoppingCartSum} Euros");
            Console.WriteLine(" ");
        }
    }
}

