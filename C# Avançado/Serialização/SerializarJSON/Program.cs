using System.IO;
using Model;
using System.Web.Script.Serialization;

namespace SerializarJSON
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

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string objetoSerializado = serializer.Serialize(usuario);
            
            StreamWriter writer = new StreamWriter(@"C:\Users\harlan.silva\Documents\Visual Studio 2017\Projects\SerializarXML\SerializerExample.json");
            writer.Write(objetoSerializado);
            writer.Close();
        }
    }
}