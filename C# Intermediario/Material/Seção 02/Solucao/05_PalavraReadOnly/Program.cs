using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PalavraReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();


            pessoa.Nome = "";
            Console.Write(pessoa.Nome);
        }
    }
}
