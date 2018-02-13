using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.setNome("Harlan");
            Console.WriteLine(pessoa.getNome());

            Console.ReadKey();
        }
    }
}
