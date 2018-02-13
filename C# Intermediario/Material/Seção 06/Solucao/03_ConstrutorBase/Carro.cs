using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConstrutorBase
{
    class Carro : Veiculo
    {

        public Carro(int i) : base(i)
        {
            Console.Write("Construindo Carro");
        }

        public override void Andar()
        {
            base.Andar();
            Console.WriteLine("Carro Andando");
        }
    }
}
