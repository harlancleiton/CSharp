using System;
using Delegate_II.Lib;

namespace Delegate_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto() {Nome = "foto.png", TamanhoX = 1368, TamanhoY = 768};
            ProcessadorFoto processadorFoto = new ProcessadorFoto();

            //Delegate Thumb
            processadorFoto.FiltroHandler = new FotoFiltro().GerarThumb;
            processadorFoto.Processador(foto);

            //Preto e Branco + Colorir
            processadorFoto.FiltroHandler = new FotoFiltro().ColorirFoto;
            processadorFoto.FiltroHandler += new FotoFiltro().PretoBranco;
            processadorFoto.Processador(foto);


            Console.ReadKey();
        }
    }
}