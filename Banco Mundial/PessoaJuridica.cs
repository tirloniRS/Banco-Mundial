using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Mundial
{
    public class PessoaJuridica : Pessoa
    {
        public List<PessoaFisica> socios = new List<PessoaFisica>(); 
        public int Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFAntasia { get; set; }
        public int InscrEstadual { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Idade { get; set; }
        public double Faturamento { get; set; }
    }    
}
