using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public override string priceTag()
        {
            return $"{Name} $ {totalPrice()} (Customs fee: {customsFee})";
        }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double totalPrice()
        {

            return Price += customsFee;
        }
    }
}
