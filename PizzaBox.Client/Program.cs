using System;
using System.Collections.Generic;

namespace PizzaBox.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program.Run();
        }

        private static void Run()
        {
            Console.WriteLine("Welcome to Pizza Box");
            var stores = new List<string>()
            {
                "Store 001",
                "Store 002",
                "Store 003"
            };

            foreach (var item in stores)
            {
                Console.WriteLine(item);
            }
        }



    }
}
