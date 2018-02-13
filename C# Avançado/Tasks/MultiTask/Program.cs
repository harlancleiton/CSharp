using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MultiTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region WaitWall

            List<Task> listTasks = new List<Task>
            {
                Task.Factory.StartNew(Metodo),
                Task.Factory.StartNew(Metodo),
                Task.Factory.StartNew(Metodo),
                Task.Factory.StartNew(Metodo),
                Task.Factory.StartNew(Metodo)
            };


            //WaitAll espera que todas as Task estejam concluidas para prosseguir
            Task.WaitAll(listTasks.ToArray());

            #endregion

            #region WaitAny

            string[] enderecos = new string[]
            {
                "http://www.google.com.br",
                "http://www.g1.com.br",
                "http://www.microsoft.com"
            };

            
            IEnumerable<Task> listaEnderecos =
                from endereco in enderecos select DownloadPaginaHtml(endereco);

            Task.WaitAll(listaEnderecos.ToArray());

            #endregion

            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
        
        #region Methods

        static void Metodo()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("I: " + i + " TaskID: " + Task.CurrentId);
            }
        }

        static async Task DownloadPaginaHtml(string endereco)
        {
            WebClient webClient = new WebClient();
            string html = await webClient.DownloadStringTaskAsync(endereco);
            Console.WriteLine("Download realizado da página: " + endereco);
        }

        #endregion
    }
}