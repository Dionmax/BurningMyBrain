using System;
using Aula122_ExercicioFixacao.Entities;
using Aula122_ExercicioFixacao.Entities.Enums;

namespace Aula122_ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Order order = new Order();

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            client.Name = Console.ReadLine();

            Console.Write("E-mail:");
            client.Email = Console.ReadLine();

            Console.Write("Birth Date: ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            order.client = client;
            order.Moment = DateTime.Now;

            Console.WriteLine("Enter order data: ");

            Console.Write("Status (PendingPayment, Processing, Shipped, Delivered): ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int cont = int.Parse(Console.ReadLine());

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                order.AddItem(new OrderItem(int.Parse(Console.ReadLine()), new Product(name, price)));
            }

            Console.WriteLine();
            Console.WriteLine(order.ToString());

        }
    }
}
