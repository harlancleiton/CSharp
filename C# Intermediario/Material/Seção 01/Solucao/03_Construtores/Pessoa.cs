using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Construtores
{
    class Pessoa
    {
        string Nome;
        string Sexo;
        DateTime DataNascimento;
        double PosicaoX, PosicaoY;
        
        public Pessoa(string nome, string sexo, DateTime dataNascimento, double X, double Y)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            PosicaoX = X;
            PosicaoY = Y;
        }
    }
}
