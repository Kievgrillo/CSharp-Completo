using PolimorfismoProduto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PolimorfismoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Produto = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    Produto.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Produto.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produto.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in Produto)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
