using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Formatar
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Elias Costa", ano = "2017";

            string texto = String.Format("Olá {0}! Feliz {1}!", nome, ano);
            Console.WriteLine(texto);

            Console.WriteLine("Olá {0}! Feliz {1}!", nome, ano);
            
            //C# 6.0
            Console.WriteLine($"Olá {nome}! Feliz {ano}!");

            Console.ReadKey();
        }
    }
}
