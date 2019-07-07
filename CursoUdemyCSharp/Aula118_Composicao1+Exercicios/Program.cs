using System;
using System.Globalization;

namespace Aula118_Composicao1_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (JUNIOR, MIDLEVEL, SENIOR): ");
            WorkedLevel level = Enum.Parse<WorkedLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, baseSalary, level, dept);

            Console.Write("How many contracts to this worker? ");
            int Works = int.Parse(Console.ReadLine());
            for (int i = 0; i < Works; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (Horus): ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, value, hours));
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string MothAndYear = Console.ReadLine();
            int Moth = int.Parse(MothAndYear.Substring(0, 2));
            int Year = int.Parse(MothAndYear.Substring(3));

            Console.WriteLine("Name: ", worker.Name);
            Console.WriteLine("Department: ", worker.Department.Name);
            Console.WriteLine("Income for " + MothAndYear + ": " + worker.Income(Year, Moth).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
