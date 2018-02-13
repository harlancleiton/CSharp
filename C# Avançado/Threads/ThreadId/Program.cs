using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadId
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(TestarThread);
                thread.Start(i);//Gambiarra, o certo e utilizar o Id interno da Thread
            }

            Console.ReadKey();
        }

        static void TestarThread(object id)
        {
            for (int i = 0; i < 100; i++)
            {
                //Console.WriteLine("Thread: " + id + " - " + i);
                Console.WriteLine("Thread: " + Thread.CurrentThread.ManagedThreadId + " - " + i);
                //Thread.CurrentThread.ManagedThreadId obtem o Id da thread em execução
            }
        }
    }
}