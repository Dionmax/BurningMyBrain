using System;
using Aula145_ExercicioFixacao.Entities;
using Aula145_ExercicioFixacao.Entities.Exception;

namespace Aula145_ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
            }
            catch (AccountException e)
            {
                Console.WriteLine("Account exception: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format exeption: " + e.Message);
            }
        }
    }
}
