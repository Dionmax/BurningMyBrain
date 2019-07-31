using System;
using System.Collections.Generic;
using System.Text;

namespace Aula196_Interfaces.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FEE_PERCENTAGE = 0.02;

        private const double MONTHLY_INTEREST = 0.01;

        public double Interest(double amount, int months)
            => amount * MONTHLY_INTEREST * months;

        public double PaymentFee(double amount)
            => amount * FEE_PERCENTAGE;
    }
}
