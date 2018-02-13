using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosWindowsForms.Lib.Mensageiro
{
    public class Email
    {
        public void EnviarMensagem(Video video)
        {
            Console.WriteLine(@"Email enviado com sucesso: " + video.Nome);
        }
    }
}
