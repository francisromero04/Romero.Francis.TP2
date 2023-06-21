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
    public class RondaTests
    {     
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void AceptarTest()
        {
            //Arrange
            Ronda ronda = new Ronda();
            ronda.TrucoCantado = true;
            Jugador jugador = null;


            //Assert
            ronda.Aceptar(jugador, jugador);
        }

        [TestMethod()]
        public void RechazarTest()
        {
            //Arrange
            Ronda ronda = new Ronda();
            ronda.TantoCantado = true;
            Jugador jugador = null;

            ronda.Rechazar(jugador);


            //Assert
            Assert.AreEqual(ronda.GanadorEnvido, jugador);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void QuieroIntercambiado()
        {
            //Arrange
            Ronda ronda = new Ronda();
            ronda.TrucoCantado = true;
            Jugador jugador = null;


            //Assert
            ronda.QuieroIntercambiado(jugador, jugador);
        }

        [TestMethod()]
        public void RetrucarTest()
        {
            //Arrange
            Ronda ronda = new Ronda();
            Jugador jugador = null;

            int valor1 = ronda.ValorDelTrucoSiSeAcepta;
            ronda.Retrucar(jugador, jugador);
            int valor2 = ronda.ValorDelTrucoSiSeAcepta;


            //Assert
            Assert.IsFalse(valor1 == valor2);
        }

        [TestMethod()]
        public void AceptarTrucoTest()
        {
            //Arrange
            Ronda ronda = new Ronda();
            Jugador jugador = null;

            ronda.AceptarTruco(jugador, jugador);
        }

        [TestMethod()]
        public void CierreDeRondaTest()
        {
            //Arrange
            Jugador jugadorUno = new Jugador("Pedro", false);
            Jugador jugadorDos = new Jugador("Mariana", true);
            Partida partida = new Partida(jugadorUno, jugadorDos);
            partida.JugadorUno.Puntos = 5;
            partida.RondaPartida.GanadorEnvido = jugadorDos;
            partida.RondaPartida.GanadorTruco = jugadorUno;
            partida.RondaPartida.ValorDelTrucoActual = 3;

            partida.RondaPartida.CierreDeRonda();

            Assert.AreEqual(partida.JugadorUno.Puntos, 8); ;
        }
    }
}