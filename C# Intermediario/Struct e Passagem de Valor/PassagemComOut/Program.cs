using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemComOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 20;
            Console.WriteLine("Main. Antes de alterar valor: " + valor);
            if(alterarValor(out valor, valor))
                Console.WriteLine("Main. Depois de alterar valor: " + valor);
            else
                Console.WriteLine("Ocorreu um erro ao tentar alterar o valor: " + valor);

            Console.ReadKey();
        }

        /*
         * Parametro out usado quando precisa-se alterar mais de um valor
         * alem do dado retornado (return)
         */
        static bool alterarValor(out int valor, int aux)
        {
            try
            {
                Console.WriteLine("Void. Antes de alterar valor(aux): " + aux);
                valor = aux + 10;
                Console.WriteLine("Void. Depois de alterar valor(aux): " + aux);
                return true;
            }
            catch
            {
                valor = 0;
                return false;
            }
        }
    }
}
