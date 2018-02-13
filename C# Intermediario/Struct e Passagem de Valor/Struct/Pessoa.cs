using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Pessoa
    {
        public int idade { set; get; }
        public string nome { set; get; }

        public Pessoa(int idade, string nome) {
            this.idade = idade;
            this.nome = nome.Trim();
        }
    }
}