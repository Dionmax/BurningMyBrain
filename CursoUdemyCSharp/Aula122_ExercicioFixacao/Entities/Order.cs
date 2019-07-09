using System;
using System.Collections.Generic;
using System.Text;
using Aula122_ExercicioFixacao.Entities.Enums;

namespace Aula122_ExercicioFixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
                sum += item.SubTotal();

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double sum = 0.0;

            sb.AppendLine("Order Summary: ");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy hh:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(client.Name);
            sb.Append(" (" + client.BirthDate.ToString("dd/MM/yyyy") + ") - ");
            sb.AppendLine(client.Email);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name + ", ");
                sb.Append("$" + item.Product.Price + ", ");
                sb.Append("Quantity: " + item.Quantity + ", ");
                sb.AppendLine("$" + item.SubTotal().ToString());

                sum += item.SubTotal();
            }

            sb.AppendLine("Total price: $" + sum);

            return sb.ToString();
        }
    }
}
