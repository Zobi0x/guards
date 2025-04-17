using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Globalization;

Product product;
OrderItem orderitem;
Client cliente;
Order order;

Console.WriteLine("Enter Client Data");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth Date DD/MM/YYYY: ");
DateTime birthdate = DateTime.Parse(Console.ReadLine());

cliente = new Client(name, email, birthdate);

Console.WriteLine("Enter Order Data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

order = new Order(DateTime.Now, status, cliente);

Console.Write("How Many Items To This Order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i + 1} Item Data ");
    Console.Write("Product Name: ");
    string pdcName = Console.ReadLine();
    Console.Write("Product Price: ");
    double pdcPrice = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
    Console.Write("Product Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    product = new Product(pdcName, pdcPrice);
    orderitem = new OrderItem(quantity, pdcPrice, product);
    order.AddContract(orderitem);
}

Console.WriteLine("ORDER SUMMARY");
Console.WriteLine(order);
Console.WriteLine($"Total Price: ${order.Total()}");
