using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception{
    class Program{
        static void Main(string[] args){
            semException();
            Console.Clear();
            comException();
        }
        static void semException(){
            Console.WriteLine("Este é o método sem exceções");
            Console.WriteLine("Digite o número 2");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 2)
                Console.WriteLine("Valor digitado corretamente.");
            else
                Console.WriteLine("Valor digitado incorretamente.");

            Console.ReadKey();
        }
        static void comException(){
            Console.WriteLine("Este é o método sem exceções");
            Console.WriteLine("Digite o número 2");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 2)
                Console.WriteLine("Valor digitado corretamente.");
            else{
                throw new System.Exception("O valor digitado não é válido!");
                Console.WriteLine("Valor digitado incorretamente.");
            }

            Console.ReadKey();
        }
    }
}
