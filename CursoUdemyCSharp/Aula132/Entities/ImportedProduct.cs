namespace Aula132.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
            => Price + CustomsFee;

        public override string PriceTag()
            => $"{Name} $ {TotalPrice()} (Customs Fee: $ {CustomsFee})";
    }
}
