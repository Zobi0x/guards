using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (Balance == 0.0)
            {
                throw new DomainException("Balance has no any value");
            }
            if (amount > Balance)
            {
                throw new DomainException("withdraw is higher than Balance value");
            }
            if (amount > WithDrawLimit)
            {
                throw new DomainException("amount is highter than withdrawlimit");
            }

            Balance -= amount;
        }
    }
}
