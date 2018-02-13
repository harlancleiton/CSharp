using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = {1, 2, 7, 23, 12, 42, 18, 9, 6, 30, 27, 62, 49};

            IEnumerable<int> listaFiltrada = i.Where(aux => aux > 20).OrderBy(aux => aux).Select(aux => aux); //Ou var
            // Ou:
            //IEnumerable<int> listaFiltrada = from aux in i where aux > 20 orderby aux select aux;

            foreach (int j in listaFiltrada)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
        }
    }
}