﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02smallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double result = 0;
            double price = 0;

            switch (town)
                
            {
                case "Sofia":
                    if (product == "coffee")
                    { price = 0.50; }
                    else if (product == "water")
                    { price = 0.80; }
                    else if (product == "beer")
                    { price = 1.20; }
                    else if (product == "sweets")
                    { price = 1.45; }
                    else if (product == "peanuts")
                    { price = 1.60; }
                    break;

                case "Plovdiv":
                    if (product == "coffee")
                    { price = 0.40; }
                    else if (product == "water")
                    { price = 0.70; }
                    else if (product == "beer")
                    { price = 1.15; }
                    else if (product == "sweets")
                    { price = 1.30; }
                    else if (product == "peanuts")
                    { price = 1.50; }
                    break;

                case "Varna":
                    if (product == "coffee")
                    { price = 0.45; }
                    else if (product == "water")
                    { price = 0.70; }
                    else if (product == "beer")
                    { price = 1.10; }
                    else if (product == "sweets")
                    { price = 1.35; }
                    else if (product == "peanuts")
                    { price = 1.55; }
                    break;
            }

            result = quantity * price;
            Console.WriteLine(result);
        }
    }
}