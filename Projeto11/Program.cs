using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria CB = new ContaBancaria();
            Console.WriteLine("Nova conta número; ");
            CB.NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome;");
            CB.Nome = Console.ReadLine();
            Console.WriteLine("Selecione; ");
            Console.WriteLine("0 - Sem depósito inicial");
            Console.WriteLine("1 - Deposito inicial");
            CB.DepositoInicial = Boolean.Parse(Console.ReadLine());
            CB.PrimeiroDeposito();

        }
    }
}
