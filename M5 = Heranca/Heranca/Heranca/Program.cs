using Heranca;
using System;
using System.Collections.Generic;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Product {i+1} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char cui = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);

    if (cui == 'i')
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(fee, name, price));
    }
    else if(cui == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY) ");
        DateTime facture = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(facture, name, price));
    }
    else if (cui == 'c')
    {
        products.Add(new Product(name, price));
    }
    else
    {
        Console.WriteLine("caractere errado");
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS");

foreach (Product p in products)
{
    Console.WriteLine(p.priceTag());
}

