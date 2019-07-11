using System;
using System.Collections.Generic;
using Aula132.Entities;

namespace Aula132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int cont = int.Parse(Console.ReadLine());

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Product #{i + 1} data: ");

                Console.Write("Common, used or imported (c / u / i) ? ");
                char choose = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customs = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, customs));
                        break;

                    case 'u':
                        Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                        break;

                    case 'c':
                        products.Add(new Product(name, price));
                        break;

                    default:
                        Console.WriteLine("Invalid!");
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPrice Tags");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
