using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 3125.04;
            int a = (int) preco;

            a = Convert.ToInt32(preco);

        }
    }
}
