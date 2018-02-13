using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosWindowsForms.Lib.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(Video video)
        {
            Console.WriteLine(@"Video enviado com sucesso: " + video.Nome);
        }
    }
}
