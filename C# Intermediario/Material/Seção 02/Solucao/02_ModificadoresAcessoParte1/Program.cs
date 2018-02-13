using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_ModificadoresAcessoParte1.Lib;

namespace _02_ModificadoresAcessoParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();

            caminhao.Marca = "VOLVO";
            carro.Marca = "FIAT";
            Console.Write(veiculo.Marca);

            //carro.Modelo

            carro.AnoModelo = new DateTime(0, 0, 2000);

        }
    }
}
