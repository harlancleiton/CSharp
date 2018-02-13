using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_e_Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2;
            Console.WriteLine("Digite o comprimeto do retangulo.(CM)\nComprimetro: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo.(CM)\nAltura: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimetro: " + calcularPerimetro(l1, l2) + ".\nArea: " + calcularArea(l1, l2) + ".\n");
            Console.ReadKey();
        }
        public static double calcularArea(double l1, double l2)
        {
            return l1 * l2;
        }
        public static double calcularPerimetro(double l1, double l2)
        {
            return 2 * l1 + 2 * l2;
        }
    }
}
