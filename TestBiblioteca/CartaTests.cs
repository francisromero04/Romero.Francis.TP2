using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca_Truco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco.Tests
{
    [TestClass()]
    public class CartaTests
    {
        [TestMethod]
        public void Test_CalcularValorCarta()
        {
            //Arrange & Act
            Carta carta = new Carta(true);

            carta.NumeroCarta = 7;
            carta.PaloCarta = EPalosCarta.Espada;

            //Assert
            Assert.IsNotNull(carta.ValorCarta = 17);
        }

        [TestMethod()]
        public void Test_CalcularValorTanto()
        {
            //Arrange & Act
            Carta carta = new Carta(true);

            carta.NumeroCarta = 11;
            carta.PaloCarta = EPalosCarta.Espada;

            //Assert
            Assert.AreEqual(carta.CalcularValorTanto(), 0);
        }

        [TestMethod()]
        public void CalcularPaloAleatorio()
        {
            //Arrange & Act
            bool resultado = (int)Carta.CalcularPaloAleatorio() < 4 && Carta.CalcularPaloAleatorio() >= 0;

            //Assert
            Assert.IsTrue(resultado);
        }
    }
}