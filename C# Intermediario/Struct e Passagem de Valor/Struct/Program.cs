using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa(22, "Harlan");
            Console.WriteLine(pessoa.nome + ": " + pessoa.idade);

            Console.ReadKey();
        }
    }
}