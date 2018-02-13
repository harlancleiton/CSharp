using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___MudarCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Harlan Cleiton da Silva";

            Console.WriteLine("Texto com letra maiuscula:");
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine("Texto com letra minuscula:");
            Console.WriteLine(nome.ToLower());

            Console.ReadKey();
        }
    }
}
