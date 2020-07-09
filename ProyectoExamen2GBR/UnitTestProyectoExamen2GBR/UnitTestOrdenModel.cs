using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoExamen2GBR.Models;

namespace UnitTestProyectoExamen2GBR
{
    [TestClass]
    public class UnitTestOrdenModel
    {
        [TestMethod]
        public void CalculoPrecioPizza()
        {
            OrdenModel orden = new OrdenModel();
            double precio = orden.calculaPrecio("mediana",2,4);
            Assert.AreEqual(7280,precio);
        }
    }
}
