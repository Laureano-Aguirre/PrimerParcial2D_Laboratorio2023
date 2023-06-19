using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Pruebas
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ContarCaracteresEspeciales_CuandoTieneCaracteresEspeciales_DebeRetornarUno()
        {
            //Arrange
            int expected = 1;
            string text = "boca*";

            //Act
            int actual = StringExtension.ContarCaracteresEspeciales(text);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarMayusculas_CuandoTieneUnaMayuscula_DebeRetornarUno()
        {
            //Arrange 
            int expected = 1;
            string text = "Boca*";

            //Act
            int actual = StringExtension.ContarMayusculas(text);

            //Assert
            Assert.AreEqual (expected, actual);
        }

        [TestMethod]
        public void ContarMinusculas_CuandoTieneAlMenosUnaMinuscula_DebeRetornarUno()
        {
            //Arrange 
            int expected = 1;
            string text = "Boca*";

            //Act
            int actual = StringExtension.ContarMinusculas(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
