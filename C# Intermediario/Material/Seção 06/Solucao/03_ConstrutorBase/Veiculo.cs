using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConstrutorBase
{
    class Veiculo
    {
        public Veiculo()
        {
            Console.Write("Construindo Veiculo");
        }
        public Veiculo(int i)
        {
            Console.Write("Construindo Veiculo N: " + i);
        }
        public virtual void Andar()
        {
            Console.WriteLine("Veiculo Andando");
        }
    }
}
