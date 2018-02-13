using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Reflection_II.Model;

namespace _05_Reflection_II
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis

            Usuario usuario = new Usuario()
            {
                Nome = "Harlan",
                Email = "harlancleiton@gmail.com",
                Senha = "123456ab"
            };

            Carro carro = new Carro()
            {
                Marca = "Ford",
                Modelo = "Fiesta"
            };

            #endregion

            Log.Gravar(usuario.Clone());
            usuario.Nome = "Harlan Cleiton";
            Log.Gravar(usuario.Clone());
            Log.Gravar(carro.Clone());

            Log.ApresentarLog();

            Console.ReadKey();
        }
    }
}
