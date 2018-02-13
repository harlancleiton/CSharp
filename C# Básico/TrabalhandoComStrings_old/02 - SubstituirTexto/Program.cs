using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___SubstituirTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Emmanuel com dois M de mulher";
            string palavraOrigem = "Emmanuel";
            string palavraFinal = "Emmanuela";
            string resultado = nome.Replace(palavraOrigem, palavraFinal);

            Console.WriteLine("Texto inicial:");
            Console.WriteLine(resultado);
            Console.WriteLine("Texto após substituição:");
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
