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
        private Boolean _depositoInicial;
        private double _valorInicial;
        private double _valorDeposito;

        private int Id
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
        public Boolean DepositoInicial
        {
            get{ return _depositoInicial; }
            set{
                _depositoInicial = value;
            }
        }
        public double ValorDeposito
        {
            get{ return _valorDeposito; }
            set{
                if (value != 0){
                    _valorDeposito = value;
                }
            }
        }
        public void PrimeiroDeposito()
        {
            if(DepositoInicial == true){
                _valorInicial = ValorInicial;
            }else{
                ValorInicial = 0;
            }
        }
        public void NovoDeposito(double ValorTotal){
            ValorTotal = ValorInicial + ValorDeposito;
        }

        public void NovoSaque(){

        }
    }
}
