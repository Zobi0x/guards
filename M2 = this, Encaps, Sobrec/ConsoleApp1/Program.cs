using ConsoleApp1;
using System;
using System.Globalization;

ContaBanco Bconta = new ContaBanco(8532, "Alex Green", 0);

Console.Write("Havera dp inical? (s/n): ");
char dpInicial = char.Parse(Console.ReadLine());

if (dpInicial == 's')
{
    Console.Write("entre o valor de dp inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Bconta.DepositoInicial(depositoInicial);
    Console.WriteLine($"Dados da conta: \n{Bconta}");
    Console.Write("Entre um valor para deposito: ");
    double dp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Bconta.Deposito(dp);
    Console.WriteLine($"Dados da conta atualizados: \n{Bconta}");
    Console.Write("Entre um valor para saque: ");
    double sq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Bconta.Saque(sq);
    Console.WriteLine($"Dados da conta atualizados: \n{Bconta}");
}
else
{
    Console.WriteLine($"Dados da conta: \n{Bconta}");
}