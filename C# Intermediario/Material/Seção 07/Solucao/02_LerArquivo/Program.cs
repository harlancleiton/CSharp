using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _02_LerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = File.ReadAllText("C:\\Users\\Elias\\Documents\\Arquivo\\texto.txt");

            Console.WriteLine(texto);

            String[] linhas = File.ReadAllLines("C:\\Users\\Elias\\Documents\\Arquivo\\texto.txt");

            Console.WriteLine("Quantidade Linhas: " + linhas.Length);

            foreach(string linha in linhas)
            {
                Console.WriteLine("Linha: " + linha);
            }

            Console.ReadKey();

        }
    }
}
