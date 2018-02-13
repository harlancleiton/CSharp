using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseInterna
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Para instanciar uma classe interna é necessário instanciar
             * também a classe externa
             */
            Pessoa.Documentos doc = new Pessoa.Documentos(); //Erro, pois a classe não é publica
            Pessoa.Endereco end = new Pessoa.Endereco();
        }
    }
}
