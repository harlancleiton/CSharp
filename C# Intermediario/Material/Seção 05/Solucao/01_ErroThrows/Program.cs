using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ErroThrows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número 1: ");
            string digitado = Console.ReadLine();

            if( digitado == "1")
            {
                Console.Write("Correto");
            }else
            {
                throw new Exception("O valor digitado não é válido!");
                Console.Write("Errado");
            }

            Console.ReadKey();

        }
    }
}
