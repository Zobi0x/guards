using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContractMain
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> list = new List<Installment>();

       

        public ContractMain(int number, DateTime date, double totalValue)
        {
            this.Number = number;
            this.Date = date;
            this.TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            list.Add(installment);
        }
    }
}
