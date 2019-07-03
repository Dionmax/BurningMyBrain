using System;
using Aula115_Enum.Entities;
using Aula115_Enum.Entities.Enums;
namespace Aula115_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 102,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            string tipoStringEnum = OrderStatus.Processing.ToString();

            // Funciona Apenas no .Net Core
           // OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(order.ToString());
        }
    }
}
