using NUnit.Framework;
using PruebaCompleta.Datos;

namespace PruebaCompleta.Unitarias
{
    [TestFixture]
    public class Pruebas
    {
        [Test]
        public void PruebaFabricaDao()
        {
            Dao objeto = FabricaDao.CrearDaoDato();

            //DaoDato prueba = new DaoDato();

            Assert.NotNull( objeto );
            //Assert.Equals( typeof( objeto ), typeof( prueba ) )
        }

    }
}