using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class VentaTest
    {
        [TestMethod]
        public void CargarVenta_DebeAgregarVenta_ListaNoVacia()
        {
            // Arrange
            Venta venta = new Venta("cliente1@gmail.com", 1000);

            // Act
            bool resultado = venta.CargarVenta(venta);
            List<Venta> listaVentas = Venta.ListaVentas;

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(1, listaVentas.Count);
            Assert.AreEqual(venta, listaVentas[0]);
        }

        [TestMethod]
        public void CalcularPago_DebeCalcularElPagoCorrectamente_Resultado0oMayorA0()
        {
            // Arrange
            decimal monto = 1000;
            decimal costoTotal = 500;

            // Act
            decimal actualPago = Venta.CalcularPago(monto, costoTotal);

            // Assert
            Assert.IsTrue(actualPago >= 0);
        }
    }
}
