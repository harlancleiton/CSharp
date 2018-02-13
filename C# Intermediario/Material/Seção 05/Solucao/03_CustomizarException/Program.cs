using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CustomizarException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MinhaException("10");
            }
            catch(Exception e)
            {
                Console.Write("ERRO: " + e.Source);
            }
            /*
            catch (MinhaException e)
            {
                Console.Write(e.Message);
            }*/
            Console.ReadKey();
        }
    }
}
