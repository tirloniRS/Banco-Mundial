using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Mundial
{
    public static class Auxiliar
    {
        // encontrei esse método na página macoratti.net
        public static int CalculaIdade(DateTime dataNascimento) {
            int Idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                Idade = Idade - 1;
            }
            return Idade;
        }
        public static string FaixaEtaria(int idade)
        {
            string faixa = null;
            if (idade <= 11)
            {
                faixa = "Criança";
            }
            else if (idade >= 12 && idade <= 21)
            {
                faixa = "Jovem";
            }
            else if (idade >= 22 && idade <= 59)
            {
                faixa = "Adulto";
            }
            else
            {
                faixa = "Idoso";
            }
            return faixa;
        }
    }
}
