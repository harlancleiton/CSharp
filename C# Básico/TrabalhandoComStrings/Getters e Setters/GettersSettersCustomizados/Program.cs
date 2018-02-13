using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSettersCustomizados
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nomeGetSet = "Harlan";
            Console.WriteLine(pessoa.nomeGetSet);

            Console.ReadKey();
        }
    }
}
