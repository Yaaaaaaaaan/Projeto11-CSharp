using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto11
{
    internal class ContaBancaria
    {
        private int _numeroConta;
        private string _nomeTitular;
        //private string _depositoInicial;
        private double _valorInicial;
        private double _valorDeposito;
        private double _valorSaque;
        private double _valorTotal;
        private int _valorTaxa = 5;

        public int NumeroConta
        {
            get{ return _numeroConta; }
            set{
                if (value >= 1){
                    _numeroConta = value;
                }
            }
        }
        public string Nome
        {
            get{ return _nomeTitular; }
            set{
                if (value != null && value.Length > 1){
                    _nomeTitular = value;
                }
            }
        }
        public double ValorInicial
        {
            get{ return _valorInicial; }
            set{
                if (value != 0){
                    _valorInicial = value;
                }
            }
        }
        //public string DepositoInicial
        //{
        //    get{ return _depositoInicial; }
        //    set{
        //        _depositoInicial = value;
        //    }
        //}
        public double ValorDeposito
        {
            get{ return _valorDeposito; }
            set{
                if (value != 0){
                    _valorDeposito = value;
                }
            }
        }
        public double ValorSaque
        {
            get { return _valorSaque; }
            set { 
                if(value != 0){
                   _valorSaque=value;
                } 
            }
        }
        public double ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }
        public int valorTaxa
        {
            get { return _valorTaxa; }
        }
        public void PrimeiroDeposito()
        {
            ValorTotal += ValorInicial;
        }
        public void NovoDeposito(){
            ValorTotal += ValorDeposito;
        }

        public void NovoSaque(){
            ValorTotal -= ValorSaque + valorTaxa;
        }
        public override string ToString()
        {
            return "Conta; "
                + _numeroConta
                + ", Nome; "
                + _nomeTitular
                + ", Saldo; "
                + _valorTotal.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
