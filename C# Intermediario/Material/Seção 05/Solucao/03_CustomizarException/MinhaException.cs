using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CustomizarException
{
    class MinhaException : Exception
    {
        string LinhaDoErro;
        public MinhaException(string Linha) : base("Minha Exception") 
        {
            LinhaDoErro = Linha;
            
        }
    }
}
