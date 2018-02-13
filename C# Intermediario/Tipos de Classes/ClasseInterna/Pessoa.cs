using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseInterna
{
    class Pessoa
    {
        class Documentos
        {
            string rg;
            string cpf;
            
           /*
            * É possível instanciar a classe à qual a classe interna pertence ou a qualquer
            * outra classe interna
            */
            public Documentos()
            {
                new Pessoa();
                new Endereco();
            }
        }

        public class Endereco
        {
            string rua;
            string bairro;
            string cidade;
            string estado;
        }
    }
}
