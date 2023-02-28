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
            };
            Console.WriteLine(CB);
            Console.ReadLine();
        }
    }
}
