using System;
using System.Collections.Generic;
using Aula136_ExChallenge.Entities;

namespace Aula136_ExChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payers> payers = new List<Payers>();

            Console.Write("Enter the number of tax payers: ");
            int cont = int.Parse(Console.ReadLine());

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");

                Console.Write("Individual or company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (payerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expend = double.Parse(Console.ReadLine());
                    payers.Add(new IndividualPayer(name, anualIncome, expend));
                }
                else if (payerType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    payers.Add(new CompanyPayer(name, anualIncome, employees));
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            double sum = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach (Payers payer in payers)
            {
                Console.WriteLine(payer.Name + ": $ " + payer.Taxes());

                sum += payer.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine("Total taxes: " + sum); ;
        }
    }
}
