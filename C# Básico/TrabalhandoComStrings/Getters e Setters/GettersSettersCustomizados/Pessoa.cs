using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSettersCustomizados
{
    class Pessoa
    {
        private string nome;
        public string nomeGetSet {
            set { nome = value; }
            get { return nome; }
        }
    }
}
