using System;
using System.IO;
using System.Xml.Serialization;
using Model;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\harlan.silva\Documents\Visual Studio 2017\Projects\SerializarXML\SerializerExample.xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(UsuarioModel));
            UsuarioModel usuario = (UsuarioModel) xmlSerializer.Deserialize(streamReader);

            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.Cpf);
            Console.WriteLine(usuario.Email);
            Console.ReadKey();
        }
    }
}
