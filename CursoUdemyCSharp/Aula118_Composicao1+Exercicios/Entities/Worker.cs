using System;
using System.Collections.Generic;
using System.Text;

namespace Aula118_Composicao1_Exercicios
{
    class Worker
    {
        private List<HourContract> contracts = new List<HourContract>();

        public string Name { get; set; }

        public double BaseSalary { get; set; }

        internal WorkedLevel Level { get; set; }

        public Department Department { get; set; }


        public Worker() { }

        public Worker(string name, double baseSalary, WorkedLevel level, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public double Income(int year, int moth)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in contracts)
                sum += contract.TotalValue();

            return sum;
        }
    }
}
