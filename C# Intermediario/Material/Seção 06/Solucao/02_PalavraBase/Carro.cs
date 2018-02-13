using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PalavraBase
{
    class Carro : Veiculo
    {
        public override void Andar()
        {
            base.Andar();
            Console.WriteLine("Carro Andando");
        }
    }
}
