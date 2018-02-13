using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(EstadoCivil.solteiro);

            Pessoa pessoa = new Pessoa();
            pessoa.estadoCivil = EstadoCivil.casado;
            Console.WriteLine("\nEstado civil da pessoa: " + pessoa.estadoCivil);
            Console.WriteLine("\nEstado civil numerico da pessoa: " + (int)pessoa.estadoCivil);

            Console.ReadKey();
        }
    }
}
