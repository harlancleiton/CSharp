using System;

namespace Delegate_II.Lib
{
    public class FotoFiltro
    {
        public void ColorirFoto(Foto foto)
        {
            Console.WriteLine("Foto colorida.\n");
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("Foto preta e branca.\n");
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("Thumb gerado.\n");
        }

    }
}
