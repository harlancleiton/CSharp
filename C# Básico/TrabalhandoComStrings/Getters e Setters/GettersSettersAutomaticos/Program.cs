using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSettersAutomaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = "Harlan";
            Console.WriteLine(pessoa.nome);

            Console.ReadKey();
        }
    }
}
