using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PropriedadeAbstrata
{
    abstract class Veiculo
    {
        abstract public String Marca { get; set; }
        abstract public String Modelo { get; }
    }
}
