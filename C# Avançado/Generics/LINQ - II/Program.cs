using System;
using System.Collections.Generic;
using System.Linq;
using LINQ_II.Model;

namespace LINQ_II
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsuarioModel> listaUsuario = new List<UsuarioModel>();
            listaUsuario.Add(new UsuarioModel() {Nome = "Harlan", Email = "harlancleiton@gmail.com"});
            listaUsuario.Add(new UsuarioModel() {Nome = "Vanessa", Email = "vanessa@hotmail.com"});
            listaUsuario.Add(new UsuarioModel() {Nome = "Conceição", Email = "conceicaof@outlook.com"});
            listaUsuario.Add(new UsuarioModel() {Nome = "Harlan", Email = "harlancleiton@hotmail.com"});
            listaUsuario.Add(new UsuarioModel() {Nome = "Tiago", Email = "tiago@mrm.com.br"});

            IEnumerable<UsuarioModel> listaFiltrada = listaUsuario.Where(aux => aux.Email.Contains("@hotmail.com")).OrderBy(aux => aux.Nome)
                .Select(aux => aux);

            foreach (UsuarioModel i in listaFiltrada)
            {
                Console.WriteLine(i.Nome + " - " + i.Email);
            }

            Console.ReadKey();
        }
    }
}