using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.dto
{
    class PessoasDto
    {
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string cpf { get; set; }
        public int rg { get; set; }
        public int cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
    }
}
