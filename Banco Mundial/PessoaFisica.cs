using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Mundial
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public int Idade { get; set; }
        public string FaixaEtaria { get; set; }
        public double Renda { get; set; }
    }

}
