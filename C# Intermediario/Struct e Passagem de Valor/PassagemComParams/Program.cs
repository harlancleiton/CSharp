using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemComParams
{
    class Program
    {
        static void Main(string[] args)
        {
            funcao01("Harlan", "Vanessa", "Conceicao");
            string[] nomes = { "Harlan", "Vanessa", "Conceicao" };
            funcao02(nomes);
            funcao03("Harlan", "Vanessa", "Conceicao");
        }

        static void funcao01(string nome1, string nome2, string nome3) { }
        static void funcao02(string[] nomes) { }
        /*
         * O uso do params ajuda a reduzi codigo
         * Deve ser o ultimo atributo a ser passado, ex: (int id, params string[] nomes)
         */
        static void funcao03(params string[] nomes) { }
    }
}
