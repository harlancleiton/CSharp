using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(TestarThread);

            thread.Start();

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
    }
}