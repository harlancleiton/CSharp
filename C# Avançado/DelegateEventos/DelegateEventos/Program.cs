using System;

namespace DelegateEventos
{
    class Program
    {
        /*
         * Funciona como uma espécie de ponteiro
         * Abstração de código
         */
        delegate int Calcular(int i, int j);

        static void Main(string[] args)
        {
            /*
             * Método normal
            Console.WriteLine("Soma: " + Somar(10, 10));
            Console.WriteLine("Subtração: " + Subtrair(20, 10));
            */

            //Com delegate
            Calcular calcular = new Calcular(Somar);
            int resultadoSoma = calcular(10, 10);
            Calcular calcular2 = new Calcular(Subtrair);
            int resultadoSub = calcular2(20, 10);

            Console.WriteLine("Soma: " + resultadoSoma);
            Console.WriteLine("Subtrair: " + resultadoSub);

            Console.ReadKey();
        }

        static int Somar(int i, int j)
        {
            return i + j;
        }

        static int Subtrair(int i, int j)
        {
            return i - j;
        }
    }
}