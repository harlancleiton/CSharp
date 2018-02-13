using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Reflection.Model;

namespace _04_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Harlan",
                Email = "harlancleiton@gmail.com",
                Senha = "123456ab"
            };

            Log.GravarUsuario(usuario);
            usuario.Nome = "Harlan Cleiton";
            Log.GravarUsuario(usuario);

            Log.ApresentarLog();

            Console.WriteLine("Log gravado");
            Console.ReadKey();
        }
    }
}
