using System;
using System.Threading;

namespace _06_ThreadAutoResetEvent_ManuelResetEvent
{
    class Program
    {
        //ResetEvent = Semaforo
        private static ManualResetEvent manualReset;
        private static AutoResetEvent autoReset;

        static void Main(string[] args)
        {
            manualReset = new ManualResetEvent(false); //False = vermelho, nao liberado
            autoReset = new AutoResetEvent(false);

            Thread thread = new Thread(Executa01);
            thread.Start();

            Thread thread2 = new Thread(Executa02);
            thread2.Start();

            Thread.Sleep(2000); //Apenas para teste
            manualReset.Set(); //Sinal verde

            Thread.Sleep(1000); //Apenas para teste
            autoReset.Set();

            Thread.Sleep(1000); //Apenas para teste
            manualReset.Reset();//Faz sinal ficar vermelho de novo
            manualReset.Set();//Sinal verde

            Thread.Sleep(1000); //Apenas para teste
            autoReset.Set();

            /*
             * Manual - preciso setar o Set() e o Reset()
             * Auto - seto o Set() e automaticamente ele trava de novo (Reset())
             */

            Console.ReadKey();
        }

        static void Executa01()
        {
            Console.WriteLine("01 - Iniciado Executa01.");
            manualReset.WaitOne(); //Esperar aqui enquanto o sinal não for verde
            Console.WriteLine("02 - Em execução Executa01.");
            Console.WriteLine("03 - Em execução parte 2 Executa01.");
            manualReset.WaitOne(); //Testar sinal vermelho de novo
            Console.WriteLine("04 - Finalizado Executa01.");
        }

        static void Executa02()
        {
            Console.WriteLine("01 - Iniciado Executa02.");
            autoReset.WaitOne();
            Console.WriteLine("02 - Em execução Executa02.");
            Console.WriteLine("03 - Em execução parte 2 Executa02.");
            autoReset.WaitOne();
            Console.WriteLine("04 - Finalizado Executa02.");
        }
    }
}