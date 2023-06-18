using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco
{
    public class Partida
    {
        #region ATRIBUTOS

        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private Ronda rondaPartida;
        private int indiceMano; //Se juegan 4 manos

        #endregion

        public Partida(Jugador primerJugador, Jugador segundoJugador)
        {
            this.jugadorUno = primerJugador;
            this.jugadorDos = segundoJugador;
            this.indiceMano = 1;
            this.rondaPartida = new Ronda();
            Ronda.Repartir(JugadorUno, JugadorDos);
            this.jugadorUno.PoseeQuiero = true;
            this.jugadorDos.PoseeQuiero = true;
        }

        #region GETTERS

        public Jugador JugadorUno { get { return jugadorUno; } }

        public Jugador JugadorDos { get { return jugadorDos; } }

        public int IndiceMano { get { return indiceMano; } }

        public Ronda RondaPartida { get { return rondaPartida; } }

        public bool PartidaTerminada
        {
            get
            {
                return indiceMano >= 4 || jugadorUno.Puntos >= 15 || jugadorDos.Puntos >= 15;
            }
        }

        #endregion

        #region METODOS UTILES

        public void ProximaRonda()
        {
            indiceMano++;
            rondaPartida = new Ronda();
            Ronda.Repartir(JugadorUno, JugadorDos);
            jugadorUno.PoseeQuiero = true;
            jugadorDos.PoseeQuiero = true;
        }

        public Jugador CalcularGanador()
        {
            Jugador ganador = null;

            if (jugadorUno.Puntos > jugadorDos.Puntos)
            {
                ganador = jugadorUno;
            }
            else if (jugadorUno.Puntos < jugadorDos.Puntos)
            {
                ganador = jugadorDos;
            }

            return ganador;
        }

        public override string ToString()
        {
            Jugador ganador = CalcularGanador();
            StringBuilder sb = new StringBuilder();

            if (ganador is null)
            {
                sb.AppendLine($"¡Empate!");
            }
            else
            {
                sb.AppendLine($"Ganador {ganador}");
            }

            return sb.ToString();
        }

        #endregion
    }
}
