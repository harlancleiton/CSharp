using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class Pessoa
    {
        private string nome;

        public string getNome() {
            return nome;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }
    }
}
