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
                User u = new User(1, "Mads", "Balslev", "Balslev", "madspbalslev@gmail.com-", 7300);
                Console.WriteLine(u.ToString());
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
