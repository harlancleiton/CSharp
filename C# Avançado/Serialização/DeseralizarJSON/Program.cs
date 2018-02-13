using System;
using System.IO;
using Model;
using System.Web.Script.Serialization;

namespace DeseralizarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader =  new StreamReader(@"C:\Users\harlan.silva\Documents\Visual Studio 2017\Projects\SerializarXML\SerializerExample.json");

            string linhasArquivo = reader.ReadToEnd();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            UsuarioModel usuario = (UsuarioModel) serializer.Deserialize(linhasArquivo, typeof(UsuarioModel));

            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.Cpf);
            Console.WriteLine(usuario.Email);
            Console.ReadKey();
        }
    }
}