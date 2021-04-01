using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstract;
using PizzaBox.Domain.Models;

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
            var stores = new List<AStore>()
            {
                new NewYorkStore(),
                new ChicagoStore()
            };

            foreach (var item in stores)
            {
                Console.WriteLine(item);
            }
        }



    }
}
