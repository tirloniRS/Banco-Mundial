using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Mundial
{
    public abstract class Pessoa
    {
        public int id { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
