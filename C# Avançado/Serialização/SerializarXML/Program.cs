using System.IO;
using System.Xml.Serialization;
using Model;

namespace SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioModel usuario = new UsuarioModel()
            {
                Nome = "Harlan",
                Cpf = "123.456.789-01",
                Email = "harlancleiton@gmail.com"
            };

            XmlSerializer serializer = new XmlSerializer(typeof(UsuarioModel));

            StreamWriter stream = new StreamWriter(@"C:\Users\harlan.silva\Documents\Visual Studio 2017\Projects\SerializarXML\SerializerExample.xml");
            //"C:\\Users\\harlan.silva\\Documents\\Visual Studio 2017\\Projects\\SerializerExample.xml"

            serializer.Serialize(stream, usuario);
        }
    }
}