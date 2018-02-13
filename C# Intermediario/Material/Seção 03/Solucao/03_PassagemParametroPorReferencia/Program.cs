using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PassagemParametroPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;

            Console.WriteLine("Main > var valor: " + valor);

            AlterarValor(ref valor);

            Console.WriteLine("Main > var valor: " + valor);

            Console.ReadKey();

        }
        static void AlterarValor(ref double valor)
        {
            Console.WriteLine("AlterarValor > var valor: " + valor);

            valor += 10;

            Console.WriteLine("AlterarValor > var valor: " + valor);
        }
    }
}
