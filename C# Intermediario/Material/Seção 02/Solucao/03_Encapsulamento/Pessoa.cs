using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulamento
{
    class Pessoa
    {
        private string Nome;
        string CEP;
        string Endereco;
        string CPF;

        public void SetNome(string nome)
        {
            Nome = nome.Trim().ToUpper();
        }

        public string GetNome()
        {
            return Nome.ToLower();
        }

        public void SetCEP(string cep)
        {
            CEP = cep;
        }
        public string GetCEP()
        {
            return CEP;
        }
    }
}
