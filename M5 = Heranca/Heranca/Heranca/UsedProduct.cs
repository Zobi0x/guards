using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct(DateTime manuFactureDate, string name, double price) : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string priceTag()
        {
            return $"{Name} (used) $ {Price} (Manufacture date: {ManuFactureDate.ToString("dd/MM/yyyy")} )";
        }
    }
}
