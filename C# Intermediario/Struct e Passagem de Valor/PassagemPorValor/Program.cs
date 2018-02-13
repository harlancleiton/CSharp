using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemPorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 20;
            Console.WriteLine("Main. Antes de alterar valor: " + valor);
            alterarValor(valor);
            Console.WriteLine("Main. Depois de alterar valor: " + valor);

            Console.ReadKey();
        }

        static void alterarValor(int valor) {
            Console.WriteLine("Void. Antes de alterar valor: " + valor);
            valor += 10;
            Console.WriteLine("Void. Depois de alterar valor: " + valor);
        }
    }
}