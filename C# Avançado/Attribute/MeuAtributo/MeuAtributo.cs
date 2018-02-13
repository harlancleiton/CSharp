using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuAtributo
{
    //Attribute:
    [AttributeUsage(AttributeTargets.All | AttributeTargets.Field | AttributeTargets.Property |
                    AttributeTargets.Method)]
    public class MeuAtributo : Attribute //Tem que herdar de Attribute
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public MeuAtributo(string nome)
        {
            this.Nome = nome;
        }
    }
}