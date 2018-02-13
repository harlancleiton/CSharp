using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Televisao
    {
        /*
         * A palavra chave this, serve para referenciar um método ou propriedade
         * da classe
         */

        private string marca;
        private string modelo;

        public void setMarca(string marca)
        {
            /*
             * Como saber qual aux se refere a variavel local da função
             * e qual se refere a atributo da classe?
             */
            this.marca = marca;
        }
    }
}