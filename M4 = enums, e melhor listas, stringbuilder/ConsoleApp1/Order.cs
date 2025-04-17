using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order
    {
        public Order()
        {
        }

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.Client = client;
        }

        public void AddContract(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveContract(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            return Items.Sum(item => item.subTotal());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name.ToString());
            sb.Append(" ");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.AppendLine(Client.Email.ToString());
            sb.AppendLine("ORDER ITEMS: ");
            foreach (OrderItem list in Items)
            {
                sb.AppendLine($"{list.Product.Name}, Quantity: {list.Quantity}, {list.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            return sb.ToString();
        }
    }
}
