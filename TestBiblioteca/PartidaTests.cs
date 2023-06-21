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
    public class PartidaTests
    {
        [TestMethod()]
        public void PartidaTerminadaTest()
        {
            //Arrange & Act
            Jugador jugadorUno = new Jugador("Pedro", true);
            Jugador jugadorDos = new Jugador("Mariana", false);
            Partida partida = new Partida(jugadorUno, jugadorDos);

            partida.JugadorUno.Puntos = 15;

            //Assert
            Assert.IsTrue(partida.PartidaTerminada);
        }

        [TestMethod]
        public void ProximaRondaTest()
        {
            //Arrange & Act
            Jugador jugadorUno = new Jugador("Pedro", true);
            Jugador jugadorDos = new Jugador("Mariana", false);
            Partida partida = new Partida(jugadorUno, jugadorDos);

            partida.ProximaRonda();

            //Assert
            Assert.AreEqual(partida.IndiceMano, 2);
        }

        [TestMethod]
        public void CalcularGanadorTest()
        {
            //Arrange & Act
            Jugador jugadorUno = new Jugador("Pedro", true);
            Jugador jugadorDos = new Jugador("Mariana", false);
            Partida partida = new Partida(jugadorUno, jugadorDos);

            partida.JugadorUno.Puntos = 15;
            partida.JugadorDos.Puntos = 15;

            //Assert
            Assert.IsNull(partida.CalcularGanador());
        }
    }
}