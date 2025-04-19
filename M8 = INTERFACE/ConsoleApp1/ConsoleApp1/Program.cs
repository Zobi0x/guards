using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.Contracts;
using System.ComponentModel;
using ConsoleApp1;

ContractMain contract;
ContractService contractService;


Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/mm/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double cValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int n = int.Parse(Console.ReadLine());

contract = new ContractMain(number, date, cValue);
contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, n);

Console.WriteLine("Instalmments:");
foreach (Installment p in contract.list)
{
    
    Console.WriteLine(p);
}
