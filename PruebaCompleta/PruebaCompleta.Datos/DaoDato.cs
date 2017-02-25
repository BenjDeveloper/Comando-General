using PruebaCompleta.Logica.Dominio;

namespace PruebaCompleta.Datos
{
    public class DaoDato : Dao
    {

        public override int RealizarCalculo(Dato elDato)
        {
            return elDato.Valor * 1000;
        }
    }
}