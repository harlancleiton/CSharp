using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfacePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            SobreVeiculo(carro);
            SobreTransport(carro);

            Console.ReadKey();
        }

        static void SobreVeiculo(Veiculo veiculo)
        {
            Console.Write(veiculo.Marca);
        }

        static void SobreTransport(ITransporte transporte)
        {
            transporte.Andar();
        }
    }
}
