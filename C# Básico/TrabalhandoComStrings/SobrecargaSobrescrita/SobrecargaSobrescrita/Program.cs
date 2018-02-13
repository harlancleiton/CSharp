using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaSobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultadoMedia;
            Sobrecarga sobrecarga = new Sobrecarga();
            resultadoMedia = sobrecarga.calcularMedia(7, 8);
            Console.WriteLine(resultadoMedia);

            Console.ReadKey();
        }
    }
}