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
        public void CalcularPago_CuandoAmbosNumerosSonPositivos_DeberiaRetornarCeroOMas()
        {
            // ARRANGE - CASO DE PRUEBA
            decimal montoCliente;
            decimal costoTotal;

            Venta venta = new Venta(montoCliente, costoTotal);
        }
    }
}
