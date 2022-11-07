﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class ShoppingCart
    {
        private static List<string> Products = new();

        public static void AddProduct(string product)
        {
            Products.Add(product);
        }

        public static void CountTotal()
        {

        }

        public static void PrintCart()
        {
            Console.WriteLine("Your shopping cart:");
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
