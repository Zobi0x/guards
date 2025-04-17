using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ContaBanco
    {
        

        public int nConta { get; private set; }
        public string tConta { get; private set; }
        public double Saldo { get; private set; }
        public double taxa = 5.00;
        public ContaBanco()
        {
        }

        public ContaBanco(int nConta, string tConta)
        {
            this.nConta = nConta;
            this.tConta = tConta;
        }

        public ContaBanco(int nConta, string tConta, double saldo) : this(nConta, tConta)
        {
            Saldo = saldo;
        }

        public void DepositoInicial(double p)
        {
            Saldo = p;
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double sq)
        {
            Saldo = Saldo - (sq + taxa);
        }

        public override string ToString()
        {
            return $"Conta {nConta}, Titular: {tConta}, Saldo: ${Saldo}";
        }
    }
}
