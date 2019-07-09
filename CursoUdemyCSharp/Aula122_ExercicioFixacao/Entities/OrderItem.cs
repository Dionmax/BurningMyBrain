using System.Text;

namespace Aula122_ExercicioFixacao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
            => Quantity * Product.Price;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Product.Name + ", ");
            sb.Append("$" + Product.Price + ", ");
            sb.Append("Quantity: " + Quantity + ", ");
            sb.AppendLine("$" + SubTotal().ToString());

            return sb.ToString();
        }
    }
}
