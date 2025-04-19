using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface OnlinePaymentService
    {
        public double paymentFee(double amount);
        public double interest(double amount, int months);
    }
}
