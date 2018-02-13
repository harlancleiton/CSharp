using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            //pessoa.SetEstadoCivil(EstadoCivil.Casado);
            Console.WriteLine("Estado Civil: " + EstadoCivil.Solteiro);
            Console.WriteLine("Estado Civil *Numerico: " + (int)EstadoCivil.Solteiro);

            Console.ReadKey();
        }
    }
}
