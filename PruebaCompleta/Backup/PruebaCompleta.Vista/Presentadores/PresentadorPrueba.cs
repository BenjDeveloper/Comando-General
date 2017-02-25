using System;
using PruebaCompleta.Logica.Comandos;
using PruebaCompleta.Logica.Dominio;
using PruebaCompleta.Vista.Contratos;
using PruebaCompleta.Logica.Fabricas;

namespace PruebaCompleta.Vista.Presentadores
{
    public class PresentadorPrueba
    {
        private IContratoPrueba _vista;


        public PresentadorPrueba( IContratoPrueba vista )
        {
            _vista = vista;
        }

        public void HandleOnCalcular()
        {
            Dato unDato = new Dato( _vista.Kilometros.Text );

            Comando elComando = FabricaComandos.CrearComandoCalcular();

            int resultado = elComando.Ejecutar( unDato );

            _vista.Metros.Text = resultado.ToString();
        }
    }
}