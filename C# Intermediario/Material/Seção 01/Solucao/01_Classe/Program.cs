using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "José Costa";
            pessoa.Sexo = "M";
            pessoa.DataNascimento = new DateTime(1974, 10, 3);

            string texto = pessoa.ResumoPessoa();

            Console.Write(texto);

            Console.ReadKey();
        }
    }
}
