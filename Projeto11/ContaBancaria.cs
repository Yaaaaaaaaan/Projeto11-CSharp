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

        public string Nome
        {
            get{ return _nomeTitular; }
            set{
                if (value != null && value.Length > 1)
                {
                    _nomeTitular = value;
                }
            }
        }
        public double ValorInicial
        {
            get { return _valorInicial; }
            set
            {
                if (value != 0)
                {
                    _valorInicial = value;
                }
            }
        }
    }
}
