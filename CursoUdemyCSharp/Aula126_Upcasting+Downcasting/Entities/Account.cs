using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126_Upcasting_Downcasting.Entities
{
    class Account
    {
        public int Number { get; private set; }

        public string Holder { get; private set; }

        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount < Balance)
                Balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
        }
    }
}
