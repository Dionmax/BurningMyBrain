using System;

namespace Aula132.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
            => $"{Name} (Used) $ {Price} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
    }
}
