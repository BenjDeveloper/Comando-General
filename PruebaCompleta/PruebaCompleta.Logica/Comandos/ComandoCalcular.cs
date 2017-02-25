using System;
using PruebaCompleta.Datos;
using PruebaCompleta.Logica.Dominio;

namespace PruebaCompleta.Logica.Comandos
{
    public class ComandoCalcular : Comando<int,Dato>
    {
        public override int Ejecutar( Dato elDato )
        {
            Dao elDao = FabricaDao.CrearDaoDato();

            return elDao.RealizarCalculo( elDato );

        }

    }
}