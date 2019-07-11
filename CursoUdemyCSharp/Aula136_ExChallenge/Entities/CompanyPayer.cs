using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136_ExChallenge.Entities
{
    class CompanyPayer : Payers
    {
        public int Employees { get; set; }

        public CompanyPayer(string name, double anualIncome, int employees)
            : base(name, anualIncome)

        {
            Employees = employees;
        }

        public override double Taxes()
            => (Employees > 10) ? AnualIncome * 0.14 : AnualIncome * 0.16;
    }
}
