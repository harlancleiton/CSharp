using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExecuteMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma 1:
            //Task.Run(() => MetodoTeste());
            //Task.Run(() => MetodoTeste());

            //Forma 2:
            Task.Factory.StartNew(MetodoTeste);
            Task.Factory.StartNew(MetodoTeste);

            Console.ReadKey();
        }

        static void MetodoTeste()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I: " + i + " TaskID: " + Task.CurrentId);
            }
        }
    }
}
