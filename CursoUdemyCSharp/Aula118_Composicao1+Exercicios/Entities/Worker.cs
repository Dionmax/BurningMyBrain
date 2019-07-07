using System;
using System.Collections.Generic;
using System.Text;

namespace Aula118_Composicao1_Exercicios
{
    class Worker
    {
        private List<HourContract> contracts;

        public string Name { get; set; }
        public double BaseSalary { get; set; }
        internal WorkedLevel Level { get; set; }
        public Department Department { get; set; }

        public void addContract(HourContract contract)
        {
            contracts.Add(contract);
        }
        public void removeContract(HourContract contract)
        {
            contracts.Remove(contract);
        }
        public double income(int year, int moth) { return 0.0; }
    }
}
