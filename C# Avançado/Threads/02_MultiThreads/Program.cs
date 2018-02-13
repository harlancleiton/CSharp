using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_MultiThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(TestarThread);
            Thread thread2 = new Thread(TestarThread2);

            thread.Start();
            thread2.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            Console.ReadKey();
        }

        static void TestarThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread: " + i);
            }
        }

        static void TestarThread2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread2: " + i);
            }
        }
    }
}
