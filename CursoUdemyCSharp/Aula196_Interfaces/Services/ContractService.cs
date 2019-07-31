using System;
using Aula196_Interfaces.Entities;

namespace Aula196_Interfaces.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePayment;

        public ContractService(IOnlinePaymentService onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int mounthCount = 1; mounthCount <= months; mounthCount++)
            {
                DateTime date = contract.Date.AddMonths(mounthCount);

                double updateQuota = basicQuota + _onlinePayment.Interest(basicQuota, mounthCount);

                double fullQuota = updateQuota + _onlinePayment.PaymentFee(updateQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
