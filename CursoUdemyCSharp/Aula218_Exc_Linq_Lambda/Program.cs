using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Aula218_Exc_Linq_Lambda.Entities;

namespace Aula218_Exc_Linq_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] str = streamReader.ReadLine().Split(',');
                        employees.Add(new Employee(str[0], str[1], double.Parse(str[2], CultureInfo.InvariantCulture)));
                    }
                }

                Console.Write("Enter salary: ");
                double salary = double.Parse(Console.ReadLine());

                //Sql Similar
                var employeeEmailList = from e
                                   in employees
                                        where e.Salary > salary
                                        orderby e.Name
                                        select e.Email;

                Console.WriteLine($"Email of people whose salary is more than {salary}: ");
                foreach (string emp in employeeEmailList)
                    Console.WriteLine(emp);

                // Linq
                var employeeSumList = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {employeeSumList}");
            }
            catch (IOException e)
            {
                Console.Write("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
