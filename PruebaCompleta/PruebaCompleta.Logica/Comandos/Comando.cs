using PruebaCompleta.Logica.Dominio;

namespace PruebaCompleta.Logica.Comandos
{
    /*public abstract class Comando
    {
        public abstract int Ejecutar( Dato data );
    }*/

    public abstract class Comando<Resultado, Parametro>
    {
        public abstract Resultado Ejecutar(Parametro p);
    }
}