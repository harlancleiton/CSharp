using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciando
{
    class Program
    {
        static void Main(string[] args){
            String nome, sexo;
            int idade;
            Console.WriteLine("Olá Mundo!");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Digite o seu nome: ");
            nome=Console.ReadLine();
            Console.Write("Qual o seu sexo?(F/M) ");
            sexo = Console.ReadLine();
            if (sexo == "F" || sexo == "f")
                sexo = "Feminino";
            else if (sexo == "M" || sexo == "m")
                sexo = "Masculino";
            else
                Console.WriteLine("Opção invalida");
            Console.Write("Digite o sua idade: ");
            //idade = int.Parse(Console.ReadLine());
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Seu nome é: " + nome + ".\nVocê é do sexo " + sexo + ".\nE você tem " + idade + " anos.");
            Console.ReadKey();
        }
    }
}