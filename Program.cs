using System;
using System.Text.RegularExpressions;
using Stregsystem.Models;

namespace Stregsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Product p = new Product(1, "Cola", 1200, 1);
                Console.WriteLine(p.ToString());
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
