using System;
using System.Collections.Generic;
using System.Text;

namespace Aula122_ExercicioFixacao.Entities
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; } = 0.0;

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
