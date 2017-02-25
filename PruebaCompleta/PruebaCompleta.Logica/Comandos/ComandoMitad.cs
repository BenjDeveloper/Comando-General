using System;
using PruebaCompleta.Datos;
using PruebaCompleta.Logica.Dominio;

namespace PruebaCompleta.Logica.Comandos
{
    public class ComandoMitad : Comando<string, int>
    {
        //Al heredar de comando se puede hacer una implementacion distinta
        public override string Ejecutar(int elDato)
        {
            int mitad = elDato / 2;

            return mitad.ToString();

        }

    }
}
