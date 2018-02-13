using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AutoImplement
{
    class Pessoa
    {
        public string Nome { get; private set; }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}
