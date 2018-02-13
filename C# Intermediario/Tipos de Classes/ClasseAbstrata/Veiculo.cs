using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    abstract class Veiculo
    {
        /*
         * Classe que não pode ser instanciada, mas pode ser herdada
         */
        public string placa { set; get; }
        public string marca { set; get; }
        public string modelo { set; get; }
    }
}