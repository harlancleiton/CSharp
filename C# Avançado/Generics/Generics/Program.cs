using System;
using Generics.Model;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = "Harlan",
                Cpf = "123.456.789-01"
            };
            Casa casa = new Casa()
            {
                Cidade = "Salvador",
                Endereco = "Ladeira do Cemitério, Periperi",
                Numero = 0
            };

            Serializador.Serializar(pessoa);
            Serializador.Serializar(casa);

            Pessoa pessoa2 = Serializador.Deserializar();
            Casa casa2 = Serializador.Deserializar();

            Console.WriteLine("Carro " +pessoa2.Nome+ " - " + pessoa2.Cpf);
            Console.WriteLine("Casa " + casa2.Cidade + " - " + casa2.Endereco + " - " + casa2.Numero);
            Console.ReadKey();
        }
    }
}