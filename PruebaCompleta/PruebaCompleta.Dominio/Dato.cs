using System;

namespace PruebaCompleta.Logica.Dominio
{
    public class Dato
    {
        private int _valor;

        public Dato(string kilometros)
        {
            _valor = Convert.ToInt32(kilometros);
        }

        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}