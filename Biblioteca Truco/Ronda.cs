using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco
{
    public class Ronda : IAccionesRonda
    {
        #region ATRIBUTOS

        private int valorActualTruco;
        private int valorTrucoAceptado;
        private int valorActualTanto;
        private int valorTantoAceptado;
        private bool trucoCantado;
        private bool tantoCantado;
        private EValorEnvido valorEnvido;
        private Carta? cartaJugadorUno;
        private Carta? cartaJugadorDos;
        private int turno;
        private int manosGanadasJugadorUno;
        private int manosGanadasJugadorDos;
        private Jugador ganadorTanto;
        private Jugador ganadorTruco;
        private Jugador ganadorPrimera;
        private Jugador canto;
        private bool tantoJugado;

        #endregion

        public Ronda()
        {
            this.valorActualTruco = 1;
            this.valorTrucoAceptado = 1;
            this.valorActualTanto = 0;
            this.valorTantoAceptado = 0;
            this.trucoCantado = false;
            this.tantoCantado = false;
            this.valorEnvido = 0;
            this.cartaJugadorUno = null;
            this.cartaJugadorDos = null;
            this.turno = 1;
            this.manosGanadasJugadorUno = 0;
            this.manosGanadasJugadorDos = 0;
            this.ganadorTanto = null;
            this.ganadorTruco = null;
            this.GanaPrimera = null;
            this.canto = null;
            this.tantoJugado = false;
        }

        #region GETTERS Y SETTERS

        public bool TrucoCantado
        {
            get
            {
                return this.trucoCantado;
            }
            set
            {
                this.trucoCantado = value;
            }
        }

        public bool TantoCantado
        {
            get
            {
                return this.tantoCantado;
            }
            set
            {
                this.tantoCantado = value;
            }
        }

        public bool TantoJugado
        {
            get
            {
                return this.tantoJugado;
            }
            set
            {
                this.tantoJugado = value;
            }
        }

        public int ValorDelTrucoActual
        {
            get
            {
                return this.valorActualTruco;
            }
            set
            {
                this.valorActualTruco = value;
            }
        }

        public int ValorDelTrucoSiSeAcepta
        {
            get
            {
                return this.valorTrucoAceptado;
            }
            set
            {
                this.valorTrucoAceptado = value;
            }
        }

        public int ValorDelTantoActual
        {
            get
            {
                return this.valorActualTanto;
            }
            set
            {
                this.valorActualTanto = value;
            }
        }

        public int ValorDelTantoSiSeAcepta
        {
            get
            {
                return this.valorTantoAceptado;
            }
            set
            {
                this.valorTantoAceptado = value;
            }
        }

        public int EstadoEnvido
        {
            get
            {
                return (int)this.valorEnvido;
            }
            set
            {
                this.valorEnvido = (EValorEnvido)value;
            }
        }

        public int ManosGanadasJugadorUno
        {
            get
            {
                return this.manosGanadasJugadorUno;
            }
            set
            {
                this.manosGanadasJugadorUno = value;
            }
        }

        public int ManosGanadasJugadorDos
        {
            get
            {
                return this.manosGanadasJugadorDos;
            }
            set
            {
                this.manosGanadasJugadorDos = value;
            }
        }

        public Jugador GanadorEnvido
        {
            get
            {
                return this.ganadorTanto;
            }
            set
            {
                this.ganadorTanto = value;
            }
        }

        public Jugador GanadorTruco
        {
            get
            {
                return this.ganadorTruco;
            }
            set
            {
                this.ganadorTruco = value;
            }
        }

        public Jugador GanaPrimera
        {
            get
            {
                return this.ganadorPrimera;
            }
            set
            {
                this.ganadorPrimera = value;
            }
        }

        public Jugador Canto
        {
            get
            {
                return this.canto;
            }
            set
            {
                this.canto = value;
            }
        }

        public Carta? CartaJugadorUno
        {
            get
            {
                return this.cartaJugadorUno;
            }
            set
            {
                this.cartaJugadorUno = value;
            }
        }

        public Carta? CartaJugadorDos
        {
            get
            {
                return cartaJugadorDos;
            }
            set
            {
                cartaJugadorDos = value;
            }
        }

        public int NumeroDeTurno
        {
            get
            {
                return (int)this.turno;
            }
            set
            {
                this.turno = value;
            }
        }

        #endregion

        public void Aceptar(Jugador jugadorQueAcepta, Jugador jugadorPasivo)
        {
            if (trucoCantado)
            {
                AceptarTruco(jugadorQueAcepta, jugadorPasivo);
            }
            else if (tantoCantado)
            {
                AceptarEnvido(jugadorQueAcepta, jugadorPasivo);
            }
        }

       public void Rechazar(Jugador jugadorPasivo)
       {
            if (tantoCantado)
            {
                RechazarEnvido(jugadorPasivo);
            }
            else
            {
                ganadorTruco = jugadorPasivo;
            }
       }

        public void QuieroIntercambiado(Jugador jugadorQueCede, Jugador JugadorQueRecibe)
        {
            jugadorQueCede.PoseeQuiero = false;
            JugadorQueRecibe.PoseeQuiero = true;
        }

       public void Retrucar(Jugador jugadorQueRetruca, Jugador jugadorPasivo)
       {
            if (this.trucoCantado)
            {
                AceptarTruco(jugadorPasivo, jugadorQueRetruca);
            }
            trucoCantado = true;
            valorTrucoAceptado++;
       }

       public void AceptarTruco(Jugador jugadorQueAcepta, Jugador jugadorPasivo)
       {
            valorActualTruco = valorTrucoAceptado;
            trucoCantado = false;
            QuieroIntercambiado(jugadorPasivo, jugadorQueAcepta);
       }

       public void ReavivarEnvido(int valorEstadoDelEnvido, int valorDeLaReavivada)
       {
            TantoCantado = true;
            EstadoEnvido = valorEstadoDelEnvido;
            valorTantoAceptado += valorDeLaReavivada;
            valorActualTanto += 1;
       }

       public void ReavivarEnvido(Partida partida)
       {
            valorTantoAceptado = 0;
            ReavivarEnvido(2, CalcularValorFaltaEnvido(partida));
       }

       public void AceptarEnvido(Jugador jugadorQueAcepta, Jugador jugadorPasivo)
        {
            valorActualTanto = this.valorTantoAceptado;
            tantoCantado = false;
            tantoJugado = true;
            if (jugadorQueAcepta.Mano.Tanto > jugadorPasivo.Mano.Tanto || jugadorQueAcepta.EsJugadorMano && jugadorQueAcepta.Mano.Tanto == jugadorPasivo.Mano.Tanto)
            {
                ganadorTanto = jugadorQueAcepta;
            }
            else
            {
                ganadorTanto = jugadorPasivo;
            }
        }
      
       public void RechazarEnvido(Jugador jugadorPasivo)
        {
            ganadorTanto = jugadorPasivo;
            tantoJugado = true;
        }

       public static void Repartir(Jugador jugadorUno, Jugador jugadorDos)
        {
            jugadorUno.Mano = new Mano(true);

            do
            {
                jugadorDos.Mano = new Mano(true);
            } while (jugadorUno.Mano == jugadorDos.Mano);

            Registro.RegistroCartasPorMano.Add(jugadorUno.Mano);
            Registro.RegistroCartasPorMano.Add(jugadorDos.Mano);
            Registro.Guardar();
        }
        
       public int CalcularValorFaltaEnvido(Partida partida)
        {
            int ret;
            Jugador puntero = partida.CalcularGanador();
            if (puntero is null)
            {
                ret = 15 - partida.JugadorUno.Puntos;
            }
            else
            {
                ret = 15 - puntero.Puntos;
            }
            return ret;
        }

       public void CierreDeRonda()
        {
            if (ganadorTanto != null)
            {
                ganadorTanto.Puntos += valorActualTanto;
            }
            ganadorTruco.Puntos += valorActualTruco;
        }
      
       public string MostrarPosicion(Partida partida, int puesto)
        {
            string puesto1 = $"{partida.JugadorUno.NombreJugador} -> {partida.JugadorUno.Puntos} pts.";
            string puesto2 = $"{partida.JugadorDos.NombreJugador} -> {partida.JugadorDos.Puntos} pts.";
            string ret;

            if (partida.JugadorUno.Puntos < partida.JugadorDos.Puntos)
            {
                puesto2 = $"{partida.JugadorUno.NombreJugador} -> {partida.JugadorUno.Puntos} pts.";
                puesto1 = $"{partida.JugadorDos.NombreJugador} -> {partida.JugadorDos.Puntos} pts.";
            }

            ret = puesto1;

            if (puesto == 2)
            {
                ret = puesto2;
            }

            return ret;
        }
        
       public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{ganadorTruco.NombreJugador} se lleva {valorActualTruco} pts. de la partida.");
            if (ganadorTanto is not null)
            {
                sb.AppendLine($"{ganadorTanto.NombreJugador} se lleva {valorActualTanto} pts. del tanto.");
            }
            else
            {
                sb.AppendLine($"No se cantó el tanto");
            }

            return sb.ToString();
        }
    }
}
