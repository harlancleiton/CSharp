using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = "Harlan"; //Erro, pois o atributo nome está declarado como "readonly" (apenas leitura)
            Console.WriteLine(pessoa.nome);

            Console.ReadKey();
        }
    }
}
