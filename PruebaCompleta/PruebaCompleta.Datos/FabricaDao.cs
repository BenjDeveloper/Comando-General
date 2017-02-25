namespace PruebaCompleta.Datos
{
    public class FabricaDao
    {
        public static Dao CrearDaoDato()
        {
            return new DaoDato();
        }
    }
}