using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PruebaCompleta.Vista.Contratos;
using PruebaCompleta.Vista.Presentadores;

namespace PruebaCompleta.Vista.Paginas
{
    public partial class FormaPrueba : System.Web.UI.Page, IContratoPrueba
    {
        private PresentadorPrueba _presentador;

        public FormaPrueba()
        {
            _presentador = new PresentadorPrueba( this );
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox Kilometros
        {
            get { return _uxKilomentros; }
        }

        public Label Metros
        {
            get { return _uxMetros; }
        }

        public Label Mitad
        {
            get { return LMitad; }
        }

        public void OnCalcular( object sender, EventArgs eventArgs )
        {
            _presentador.HandleOnCalcular();
            _presentador.CalcularMitad();
        }
    }
}