using System;
using System.IO;
using System.Collections.Generic;
namespace stregsystem.Models
{
    public class Stregsystem
    {
        private List<Product> _products = new List<Product>();
        private List<User> _users;

        private void InitializeProducts()
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
        public List<Product> ActiveProducts() => _products.FindAll(p => p.Active);
        private void PrintToConsole<T>(List<T> l) where T : IPrintable
        {
            foreach (T i in l)
            {
                System.Console.WriteLine(i.ToString());
            }
        }

        public void Run()
        {
            InitializeProducts();
            PrintToConsole<Product>(ActiveProducts());
        }
    }
}