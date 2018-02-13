using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_EscreverArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter arquivo = new StreamWriter("C:\\Users\\Elias\\Documents\\Arquivo\\texto.txt");

            arquivo.WriteLine("Olá este é o meu primeiro arquivo");
            arquivo.WriteLine("Bem vindo ao ano 2017! \n Lhes desejo o melhor ano da suas vidas!");

            arquivo.Close();

            Console.Write("Arquivo gravado!");
            Console.ReadKey();
        }
    }
}
