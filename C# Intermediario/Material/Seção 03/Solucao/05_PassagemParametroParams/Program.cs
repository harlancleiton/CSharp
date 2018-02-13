using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PassagemParametroParams
{
    class Program
    {
        static void Main(string[] args)
        {
            VariasEntradas01("Elias", "José", "Maria");

            string[] nomes = { "Elias", "José", "Maria", "Filipe" };
            VariasEntradas02(nomes);

            VariasEntradas03(10, "Elias", "José", "Maria", "Filipe", "Jesus");           
        }

        static void VariasEntradas01(string nome1, string nome2, string nome3)
        {

        }
        static void VariasEntradas02(string[] nomes)
        {

        }
        static void VariasEntradas03(int idade, params string[] nomes)
        {

        }
    }
}
