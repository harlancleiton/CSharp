using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___VerificarSeTextoExiste
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Harlan Cleiton da Silva";
            string inicio = "Harlan";
            string final = "Silva";
            string qualquerLugar = "Cleiton";

            Console.WriteLine("Verificar se a palavra " + inicio + " está no começo da string: " + nome.StartsWith(inicio));
            Console.WriteLine("Verificar se a palavra " + final + " está no final da string: " + nome.EndsWith(final));
            Console.WriteLine("Verificar se a palavra " + qualquerLugar + " está na string: " + nome.Contains(qualquerLugar));

            Console.ReadKey();
        }
    }
}