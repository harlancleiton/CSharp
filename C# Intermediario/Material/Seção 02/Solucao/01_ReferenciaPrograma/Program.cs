using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Biblioteca;
using _02_ModificadoresAcessoPratica.Biblioteca;

namespace _02_ReferenciaPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoJuros calc = new CalculoJuros();
            double resultado = calc.Soma(10, 20);
            
            Console.WriteLine("Resultado da soma: " + resultado);
            Console.ReadKey();
        }
    }
}
