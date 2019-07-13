using System;
using System.Collections.Generic;
using System.Text;
using Aula145_ExercicioFixacao.Entities.Exeption;

namespace Aula145_ExercicioFixacao.Entities
{
    class Account
    {
        public int Number { get; set; }

        public string Holder { get; set; }

        public double Balance { get; set; }

        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance < 0 || withdrawLimit < 0)
            {
                throw new AccountExeption("Negative values are not allowed.");
            }


            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new AccountExeption("Negative values are not allowed for deposit.");
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
                throw new AccountExeption("The amount exceeds withdraw limit.");

            if (amount > Balance)
                throw new AccountExeption(" Not enough balance.");

            if (amount < 0)
                throw new AccountExeption("Negative values are not allowed.");

            Balance -= amount;
        }
    }
}
