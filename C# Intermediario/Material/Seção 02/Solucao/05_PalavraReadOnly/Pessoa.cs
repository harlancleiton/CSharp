using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PalavraReadOnly
{
    class Pessoa
    {
        public readonly double PI = 3.14;

        public readonly string Nome = "Elias Costa";

        Pessoa()
        {
            Nome = "João";
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}
