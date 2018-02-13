using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    class Carro : Veiculo
    {
        public Carro(string marca, string modelo, string placa)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
        }
    }
}
