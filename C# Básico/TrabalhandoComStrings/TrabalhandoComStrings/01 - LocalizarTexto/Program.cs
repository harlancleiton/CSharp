using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___LocalizarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Harlan Cleiton da Silva Harlan Cleiton da Silva";
            string pesquisar = "Silva";
            int resultado = nome.IndexOf(pesquisar);
            Console.WriteLine("O texto " + pesquisar + " foi encontrado primeiramente no caractere " + resultado + ".");
            resultado = nome.LastIndexOf(pesquisar);
            Console.WriteLine("O texto " + pesquisar + " foi encontrado por último no caractere " + resultado + ".");

            Console.ReadKey();
        }
    }
}