using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco
{
    public class Jugador
    {
        #region ATRIBUTOS

        private Mano mano;
        private int puntos;
        private string nombreJugador;
        private bool esJugadorMano;
        private bool esSuTurno;
        private bool poseeQuiero;
        private int cantidadVictorias;

        #endregion

        public Jugador(string nombreJugador, bool esJugadorMano)
        {
            this.nombreJugador = nombreJugador;
            this.esJugadorMano = esJugadorMano;
            this.esSuTurno = esJugadorMano;
            this.mano = new Mano();
            cantidadVictorias = 0;
        }

        #region GETTERS Y SETTERS

        public int Puntos
        {
            get
            {
                return this.puntos;
            }
            set
            {
                this.puntos = value;
            }
        }

        public string NombreJugador
        {
            get
            {
                return this.nombreJugador;
            }
        }

        public bool EsSuTurno
        {
            get
            {
                return this.esSuTurno;
            }
            set
            {
                this.esSuTurno = value;
            }
        }

        public bool EsJugadorMano
        {
            get
            {
                return this.esJugadorMano;
            }
            set
            {
                this.esJugadorMano = value;
            }
        }

        public bool PoseeQuiero
        {
            get
            {
                return this.poseeQuiero;
            }
            set
            {
                this.poseeQuiero = value;
            }
        }

        public Mano Mano
        {
            get
            {
                return this.mano;
            }
            set
            {
                this.mano = value;
            }
        }

        public int CantidadVictorias
        {
            get
            {
                return cantidadVictorias;
            }
            set
            {
                cantidadVictorias = value;
            }
        }

        public override string ToString()
        {
            return $"El jugador {this.nombreJugador} tiene el siguiente puntaje: {this.puntos} pts.";
        }

        #endregion
    }
}
