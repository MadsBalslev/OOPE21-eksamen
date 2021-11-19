using System;
using System.IO;
using System.Collections.Generic;
namespace stregsystem.Models
{
    public static class Stregsystem
    {
        private static List<Product> _products = new List<Product>();
        private static List<User> _users;

        private static void InitializeProducts()
        {
            _products.Clear(); // Start with empty list
            StreamReader reader = new StreamReader("./_data/products.csv");
            // Skip first line
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                 string line = reader.ReadLine();
                 string[] v = line.Split(';');
                 _products.Add(new Product(int.Parse(v[0]), v[1], decimal.Parse(v[2]), int.Parse(v[3])));
            }
        }
        public static List<Product> ActiveProducts() => _products.FindAll(p => p.Active);
        private static void PrintToConsole<T>(List<T> l)
        {
            foreach (T i in l)
            {
                System.Console.WriteLine(i.ToString());
            }
        }

        public static void Run()
        {
            InitializeProducts();
            PrintToConsole<Product>(ActiveProducts());
        }
    }
}