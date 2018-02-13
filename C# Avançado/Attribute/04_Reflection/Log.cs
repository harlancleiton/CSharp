using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Reflection.Model;

namespace _04_Reflection
{
    class Log
    {
        public static List<Usuario> ListUsuarios = new List<Usuario>();
        public static List<Carro> ListCarros = new List<Carro>();

        public static void GravarUsuario(Usuario usuario)
        {
            ListUsuarios.Add((Usuario)usuario.Clone());
        }

        public static void GravarCarro(Carro carro)
        {
            ListCarros.Add(carro);
        }

        public static void ApresentarLog()
        {
            foreach (Usuario usuario in ListUsuarios)
            {
                Console.WriteLine("Nome: {0}, Email: {1}, Senha: {2}", usuario.Nome, usuario.Email, usuario.Senha);
            }

            foreach (Carro carro in ListCarros)
            {
                Console.WriteLine("Marca: {0}, Modelo: {1}", carro.Marca, carro.Modelo);
            }
        }
    }
}