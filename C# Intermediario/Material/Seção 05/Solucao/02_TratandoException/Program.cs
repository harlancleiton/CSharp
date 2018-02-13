using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TratandoException
{
    class Program
    {
        static void Main(string[] args)
        {
            string gerarcodigo;
            try
            {
                //Código que pode gerar erro;
                Pessoa pessoa = new Pessoa();
                pessoa.SetCEP("ABC10");
            }
            catch (FormatException forExcep)
            {
                Console.WriteLine("ERRO FORMAT: " + forExcep.Message);
            }
            catch(Exception excep)
            {
                Console.WriteLine("ERRO: " + excep.Message);
            }
            finally
            {
                gerarcodigo = null;
            }
            

            Console.ReadKey();
        }
    }
}
