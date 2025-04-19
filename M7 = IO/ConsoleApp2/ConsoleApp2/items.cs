using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class items
    {
        public string Name { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }

        public items(string name, double price, double quantity)
        {
            Name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double Total()
        {
            return price * quantity;
        }
    }
}
