using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContractService
    {
        private OnlinePaymentService _OnPayService;
        public void ProcessContract(ContractMain contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _OnPayService.interest(basicQuota, i);
                double fullQuota = updatedQuota + _OnPayService.paymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
        
        public ContractService(OnlinePaymentService onPayService)
        {
            _OnPayService = onPayService;
        }
    }
}
