using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136_ExChallenge.Entities
{
   abstract class Payers
    {
        public string Name  { get; set; }

        public double AnualIncome { get; set; }

        protected Payers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();
    }
}
