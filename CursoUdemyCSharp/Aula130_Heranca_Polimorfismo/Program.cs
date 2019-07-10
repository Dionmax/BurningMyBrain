using System;
using Aula130_Heranca_Polimorfismo.Entities;
using System.Collections.Generic;

namespace Aula130_Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int contador = int.Parse(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced (y/n)? ");
                bool outscr = (Console.ReadLine() == "y") ? true : false;

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double vph = double.Parse(Console.ReadLine());

                if (outscr)
                {
                    Console.Write("Additional charge: ");
                    double additionCharge = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourceEmployee(name, hours, vph, additionCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, vph));
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment());
            }
        }
    }
}

