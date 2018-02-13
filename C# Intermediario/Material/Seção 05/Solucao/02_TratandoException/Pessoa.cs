using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TratandoException
{
    class Pessoa
    {
        private string Nome;
        private string CPF;
        private string CEP;

        public void SetCEP(string cep)
        {
            int resultado;
            int.Parse(cep);
            if( int.TryParse(cep, out resultado))
            {
                //Valido
                CEP = cep;
            }else
            {
                throw new Exception("CEP Inválido!");
            }
        }


    }
}
