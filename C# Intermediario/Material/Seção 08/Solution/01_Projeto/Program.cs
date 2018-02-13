using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Projeto.Telas;
namespace _01_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes = 0;
            while (opcoes != 5)
            {
                Console.WriteLine("O deseja fazer? \n(1 = Cadastrar Cliente, 2 = Listar Cliente, 3 = Cadastrar Funcionario, 4 = Listar Funcionário, 5 = Fechar Programa)");
                opcoes = int.Parse(Console.ReadLine());

                ManterCliente telaCliente = new ManterCliente();
                ManterFuncionario telaFuncionario = new ManterFuncionario();
                switch (opcoes)
                {
                    case 1:
                        telaCliente.CadastrarCliente();
                        break;
                    case 2:
                        telaCliente.ListarClientes();
                        break;
                    case 3:
                        telaFuncionario.CadastrarFuncionario();
                        break;
                    case 4:
                        telaFuncionario.ListarFuncionarios();
                        break;
                    case 5:
                        //opcoes = 5;
                        break;
                    default:
                        Console.WriteLine("Comando não encontrado!");
                        break;
                }
            }
        }
    }
}
