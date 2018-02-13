using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratarExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            comException(pessoa);

            Console.ReadKey();
        }
        static void comException(Pessoa pessoa)
        {
            Console.WriteLine("Digite um numero qualquer.");
            string numero = Console.ReadLine();

            try
            {
                pessoa.setarCpf(numero);
                Console.WriteLine("Número digitado.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}