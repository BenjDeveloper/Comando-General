using PruebaCompleta.Logica.Comandos;
using PruebaCompleta.Logica.Dominio;

namespace PruebaCompleta.Logica.Fabricas
{
    public class FabricaComandos
    {
        public static Comando<int,Dato> CrearComandoCalcular()
        {
            return new ComandoCalcular();
        }

        public static Comando<string, int> CrearComandoMitad()
        {
            return new ComandoMitad();
        }
    }
}