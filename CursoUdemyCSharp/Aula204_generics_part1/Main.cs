using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula204_generics_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintServiceProgram printServiceProgram = new PrintServiceProgram();

            Console.Write("How many values?: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printServiceProgram.AddValue(x);
            }

            printServiceProgram.Print();

            Console.WriteLine("First: " + printServiceProgram.First());
        }
    }
}
