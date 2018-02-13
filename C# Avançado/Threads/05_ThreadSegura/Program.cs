using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_ThreadSegura
{
    class Program
    {
        static object Controle = 0;

        static int Rede = 0;

        static void Main(string[] args)
        {
            /*
             * Faz com que a thread seja totalmente dependende do processo principal
             * Desse modo quando a thread principal parar o programa não vai esperar finalizar
             * a thread para encerrar o programa.
             */

            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(TestarThread);
                thread.IsBackground = true;
                thread.Start();
            }

            Console.ReadKey();
        }

        static void TestarThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                //Lock faz com que as threads não executem ao mesmo tempo o mesmo recurso
                lock (Controle)
                {
                    Console.WriteLine("Thread: " + i);
                    Rede++;
                }
            }
        }
    }
}