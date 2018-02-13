using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePacial
{
	/*
	 * Classe usada geralmente quando muitos programadores trabalham numa classe, os métodos e atributos implementados
	 * numa parte da classe fica disponivel nas outras
	 * Usada também em projetos multiplataformas, onde são criados vários projetos e classes parciais que utulizam
	 * os métodos e atributos do "projeto principal"
	 */
    partial class Carro
    {
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
