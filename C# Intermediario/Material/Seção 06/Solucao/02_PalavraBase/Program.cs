using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PalavraBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Andar();

            Carro carro = new Carro();
            carro.Andar();
            Console.ReadKey();
        }
    }
}
