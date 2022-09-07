using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Mundial
{
    public abstract class Conta
    {
        public Pessoa Titular { get; set; }
        public long Numero { get; set; }
        public int Agencia { get; set; }
        private double Saldo { get; set; }
        public double TaxaSaque { get; set; }

        public void Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
        }
        public double ConsultarSaldo()
        {
            return this.Saldo;
        }

        public void Transferir(Conta conta, double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                conta.Saldo += valor;
            }
        }
    }
}
