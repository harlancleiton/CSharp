using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Reflection_II
{
    class Log
    {
        public static List<object> ListObjects = new List<object>();

        public static void Gravar(object obj)
        {
            ListObjects.Add(obj);
        }

        public static void ApresentarLog()
        {
            foreach (object obj in ListObjects)
            {
                Console.WriteLine("Nome da classe: {0}.", obj.GetType().Name);
                foreach (var property in obj.GetType().GetProperties())
                {
                    Console.WriteLine("Propriedade {0}: {1}", property.Name, property.GetValue(obj));
                }
                Console.WriteLine("\n");
            }
        }
    }
}