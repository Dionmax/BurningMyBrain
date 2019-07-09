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
    }
}
