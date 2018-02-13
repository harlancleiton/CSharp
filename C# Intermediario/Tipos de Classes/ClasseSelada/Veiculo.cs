using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseSelada
{
    /*
     * Classe selada
     * Não é possível servi de base para outras classes, ou seja,
     * não é possível herdar dessa classe
     */
    sealed class Veiculo
    {
        string marca, modelo, placa;
    }
}
