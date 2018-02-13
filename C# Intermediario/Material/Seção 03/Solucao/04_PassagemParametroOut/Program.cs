using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PassagemParametroOut
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;

            Console.WriteLine("Main > var valor: " + valor);

            AlterarValor(out valor);
            int idade;
            string nome = RetornarNomeIdadePessoa(new DateTime(10,10,2000), out idade);
            
            //int.TryParse()

            Console.WriteLine("Main > var valor: " + valor);

            Console.ReadKey();

        }
        static void AlterarValor(out double valor)
        {
            valor = 10;
        }
        static string RetornarNomeIdadePessoa(DateTime dataNascimento, out int idade)
        {
            idade = 10;
            return "Nome";
        }
    }
}
