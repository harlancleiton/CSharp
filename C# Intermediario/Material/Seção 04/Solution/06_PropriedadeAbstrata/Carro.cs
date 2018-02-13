using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PropriedadeAbstrata
{
    class Carro : Veiculo
    {
        public override string Marca
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Modelo
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
