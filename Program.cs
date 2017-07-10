using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // In Main method, create a list of value tuples that will hold individual transactions for a hardware business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("screwdriver", 5.00, 9));
            transactions.Add(("hammer", 7.99, 10));
            transactions.Add(("drill", 49.39, 15));
            transactions.Add(("nails", 0.10, 100));
            transactions.Add(("extension cord", 10.50, 4));

            int totalSold = 0;
            double totalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
                {
                   totalSold += t.quantity;
                   totalRevenue += t.amount*t.quantity;   
                }
                Console.WriteLine($"Items sold today {totalSold}");
                Console.WriteLine($"Total revenue {totalRevenue:C}");
            }
        }
    }

