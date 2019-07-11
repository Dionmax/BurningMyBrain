using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136_ExChallenge.Entities
{
    class IndividualPayer : Payers
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
            => ((HealthExpenditures > 20000.00) ? AnualIncome * 0.15 : AnualIncome * 0.25) - HealthExpenditures * 0.5;
    }
}
