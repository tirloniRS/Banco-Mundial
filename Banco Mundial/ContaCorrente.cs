using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Mundial
{
    public class ContaCorrente : Conta
    {
        public string Tipo { get; set; }
        public double Limite { get; set; }
        public double TaxaLimite { get; set; }

        public void Pagar(string codigoBarras)
        {

        }

        public void Emprestimo(double valor)
        {

        }
    }
}
