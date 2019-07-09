using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126_Upcasting_Downcasting.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount > 0 && amount < LoanLimit)
                Balance += amount;
        }
    }
}
