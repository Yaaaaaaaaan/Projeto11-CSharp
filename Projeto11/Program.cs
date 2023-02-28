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
            Console.WriteLine("Desejas depósito inicial? (S/N) ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.WriteLine("Insira o valor do depósito inicial; ");
                CB.ValorInicial = double.Parse(Console.ReadLine());
                CB.PrimeiroDeposito();
                Console.WriteLine("Dados da conta; " + CB);
            };
            
            Console.WriteLine("Novo depósito; ");
            CB.ValorDeposito = double.Parse(Console.ReadLine());
            CB.NovoDeposito();
            Console.WriteLine("Dados atualizados; " + CB);
            Console.WriteLine("Novo Saque; ");
            CB.ValorSaque = double.Parse(Console.ReadLine());
            CB.NovoSaque();
            Console.WriteLine("Dados atualizados; " + CB );
            Console.WriteLine(" Para encerrar aperte qualquer tecla.");
            Console.ReadLine();
        }
    }
}
