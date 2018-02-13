using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco = 10;
            int aux;
            aux = preco; //Erro, pois float > int
            aux = Convert.ToInt32(preco); //Metodo 1
            aux = (int)preco; //Metodo 2 (casting)
        }
    }
}