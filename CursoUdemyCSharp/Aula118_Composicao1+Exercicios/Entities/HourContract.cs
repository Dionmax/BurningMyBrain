using System;
using System.Collections.Generic;
using System.Text;

namespace Aula118_Composicao1_Exercicios
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public double totalValue()
            => Hour * ValuePerHour;
    }
}
