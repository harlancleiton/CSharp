using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClasseInterna
{
    class Pessoa
    {
        void GetOlhos()
        {
            Olho olho = new Olho();
        }
        public class Olho
        {
            public static string Iris = "XYZ";
            public Olho()
            {
                Pessoa pessoa = new Pessoa();
            }
        }
    }
}
