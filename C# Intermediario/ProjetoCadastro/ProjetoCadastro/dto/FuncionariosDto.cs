using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.dto
{
    class FuncionariosDto : PessoasDto
    {
        public string cargo { get; set; }
        public float salario { get; set; }
    }
}
