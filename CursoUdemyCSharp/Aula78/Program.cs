using System;
using System.Collections.Generic;

namespace Aula78 {
    class Program {
        static void Main(string[] args) {
            List<Employees> employee = new List<Employees>();

            Console.WriteLine("Quantos funcionarios será registrado?");
            int contador = int.Parse(Console.ReadLine());

            for (int i = 0; i < contador; i++) {
                Console.WriteLine("Id do funcionario: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome do funcionário: ");
                string name = (Console.ReadLine());
                Console.WriteLine("Salario do mesmo: ");
                float salario = float.Parse(Console.ReadLine());

                employee.Add(new Employees(id, name, salario));
            }

            foreach (var item in employee) {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Id do funcionario que terá o salario aumento: ");
            int IdBusca = int.Parse(Console.ReadLine());

            // A função find busca o id da lista.
            Employees funcionarioTemp = employee.Find(x => x.id == IdBusca);

            if (funcionarioTemp != null) {
                Console.WriteLine("Digite a porcentagem que vai aumentar: ");
                float aumento = float.Parse(Console.ReadLine());

                funcionarioTemp.aumentarSalario(aumento);
            }
            else {
                Console.WriteLine("Id não existe.");
            }

            foreach (var item in employee) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
