using System;

namespace Fast_Food
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char action=' ', action2=' ';
			double valortotal=0, valor=0, dinheiro=0, troco=0;
			int quantidade=0;

			while (action=='N' || action!='n') { //WHILE DO PROGRAMA
				Console.WriteLine ("Bem vindo ao Fast Food C#!\nPor favor, escolha o item desejado.\n\n");

				while (action!='4') { //WHILE DA COMPRA
					Console.WriteLine ("-------------------------------------------------------------------\n");
					Console.WriteLine (" OPCAO |    PROMOCAO    |           DESCRICAO            | PRECO(R$)\n");
					Console.WriteLine ("-------------------------------------------------------------------\n");
					Console.WriteLine ("   1   | Big Super      | 2 hamburgueres, queijo, batata | 5,00\n");
					Console.WriteLine ("       |                | frita e refrigerante           |\n");
					Console.WriteLine ("-------------------------------------------------------------------\n");
					Console.WriteLine ("   2   | Quase Super    | 1 hamburguer, batata frita e   | 3,00\n");
					Console.WriteLine ("       |                | refrigerante                   |\n");
					Console.WriteLine ("-------------------------------------------------------------------\n");
					Console.WriteLine ("   3   | Promocao Misto | 1 misto quente e refrigerante  | 1,50\n");
					Console.WriteLine ("-------------------------------------------------------------------\n");
					Console.WriteLine ("   4   | Sair e exibir  |                                |\n");
					Console.WriteLine ("       | total          |                                |\n");
					Console.WriteLine ("-------------------------------------------------------------------\n\n");
					action=Convert.ToChar(Console.ReadLine());
					while (action!='1' && action!='2' && action!='3' && action!='4')
					{ //CASO NAO SEJA SELECIONADO NENHUM ITEM DO MENU
						Console.WriteLine("Opcao invalida!\nEscolha uma opcao valida.\n");
						action=Convert.ToChar(Console.ReadLine());
					}
					if (action=='4' && valortotal==0)
					{ //CASO SAIA SEM COMPRAR NADA
						Console.WriteLine("Nenhum item foi comprado!\nPrograma sendo encerrado..\n");
					}
					if (action!='4')
					{ //QUANTIDADE
						Console.WriteLine("Digite a quantidade de itens.\n");
						quantidade=Convert.ToChar(Console.ReadLine());
					}
					//PARTE DOS CALCULOS
					if (action=='1'){
						valor=5.00;
						valortotal=valortotal+valor*quantidade;
					}
					else if (action=='2'){
						valor=3.00;
						valortotal=valortotal+valor*quantidade;
					}
					else if (action=='3'){
						valor=1.50;
						valortotal=valortotal+valor*quantidade;
					}
					Console.WriteLine("Total a pagar: R$" + valortotal + ",00\n");
					Console.Clear ();
				}
				Console.ReadKey ();
			}
		}
	}
}