using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    class Carro : Veiculo, ITransporte
    {
        public void Mover(byte velocidade)
        {
            Console.Write("Aqui está a ação mover...");
        }
    }
}
