using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoParcial
{
	/*
	 * Método parcial não pode conter modificador de acesso
     * Deve sempre ser privado
     * Não retorna informações, ou seja, sempre será void
	 */
    partial class Carro
    {
        partial void ExibiInformacoes();
		public string getMarca() 
		{
            return marca;
        }
        public void setMarca(string marca) 
		{
            this.marca = marca;
        }
    }
}
