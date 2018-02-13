using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoParcial
{
    partial class Carro
    {
        string marca;
        string modelo;
        string placa;
        int ano;

        partial void ExibiInformacoes()
        {
            Console.WriteLine("Marca: " + getMarca());
        }
    }
}