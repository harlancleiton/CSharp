namespace Delegate_II.Lib
{
    public class ProcessadorFoto
    {
        public delegate void FotoFiltroHandler(Foto foto);
        public FotoFiltroHandler FiltroHandler;

        public void Processador(Foto foto)
        {
            FiltroHandler(foto);
            /*
             * FotoFiltro fotoFiltro = new FotoFiltro();
             * fotoFiltro.ColorirFoto(foto);
             * fotoFiltro.PretoBranco(foto);
             * fotoFiltro.GerarThumb(foto);
             */
        }
    }
}
