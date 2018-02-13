using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratarExcecoes
{
    class Pessoa
    {
        public int cpf { set; get; }

        public void setarCpf(string cpf)
        {
            this.cpf = int.Parse(cpf);
            /*
             * Ou assim:
            int aux;
            if(int.TryParse(cpf, out aux))
            {
                this.cpf = aux;
            }
            else
            {
                throw new Exception("Não foi digitado nenhum número");
            }
            */
        }
    }
}
