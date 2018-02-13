using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfacePolimorfismo
{
    class Carro : Veiculo, ITransporte
    {
        public void Andar()
        {
            Console.WriteLine("Carro andando...");
        }
    }
}
