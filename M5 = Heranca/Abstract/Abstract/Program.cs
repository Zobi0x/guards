using Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;

List<People> peoples = new List<People>();

Console.Write("Enter the number of tax players: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Tax payer {i+1} data");
    Console.Write("Individual or Company? (i/c)? ");
    char iORc = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual Income: ");
    double aIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (iORc == 'i')
    {
        Console.Write("Health Expenditures: ");
        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        peoples.Add(new Individual(name, aIncome, health));
    }
    else if (iORc == 'c')
    {
        Console.Write("Number of Employees: ");
        int nEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        peoples.Add(new Company(name, aIncome, nEmployees));
    }
}

Console.WriteLine("TAXES PAID:");

double sum = 0.0;

foreach (People p in peoples)
{
    double tax = p.tax();
    Console.WriteLine($"{p.Name}: $ {p.tax().ToString("F2", CultureInfo.InvariantCulture)}");
    sum += tax;
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));


