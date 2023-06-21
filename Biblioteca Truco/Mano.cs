using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Truco
{
    public class Mano
    {
        #region ATRIBUTOS

        [XmlIgnore]
        private ManoDeCartas<Carta> cartas;
        private double tanto;
        private bool tieneFlor;

        #endregion

        /// <summary>
        /// Constructor vacío.
        /// </summary>
        public Mano()
        {
            this.cartas = new ManoDeCartas<Carta>();
        }

        public Mano(bool randomizar)
        {
            Carta carta;
            cartas = new ManoDeCartas<Carta>();

            do
            {
                carta = new Carta(true);

                if (ValidarCarta(carta))
                {
                    cartas.AgregarCarta(carta);
                }

            } while (cartas.CantidadDeCartas() < 3);

            cartas.OrdenarPorValor(OrdenamientoPorValor);
            tanto = CalcularTanto();
            tieneFlor = CalcularSiTieneFlor();

            if (tanto == 0)
            {
                tanto = CalcularTantoSoloFiguras();
            }
        }

        #region GETTERS Y SETTERS

        public double Tanto
        {
            get
            {
                return this.tanto;
            }
            set
            {
                this.tanto = value;
            }
        }

        public ManoDeCartas<Carta> Cartas
        {
            get
            {
                return this.cartas;
            }
            set
            {
                this.cartas = value;
            }
        }

        public bool TieneFlor
        {
            get
            {
                return this.tieneFlor;
            }
            set
            {
                this.tieneFlor = value;
            }
        }

        #endregion

        #region CALCULADORES

        public int CalcularTanto()
        {
            int retorno = 0;

            if (CalcularSiTieneFlor())
            {
                retorno += 20;
                foreach (Carta c in Cartas)
                {
                    retorno += c.PuntajeTanto;
                }
            }
            else if (CalcularSiTieneTanto())
            {
                retorno = CalcularTantoDoble();
            }
            else
            {
                foreach (Carta c in Cartas)
                {
                    if (c.PuntajeTanto > retorno)
                    {
                        retorno = c.PuntajeTanto;
                    }
                }
            }

            return retorno;
        }

        public bool CalcularSiTieneFlor()
        {
            if (Cartas[0].PaloCarta == Cartas[1].PaloCarta && Cartas[0].PaloCarta == Cartas[2].PaloCarta)
            {
                return true;
            }

            return false;
        }

        public bool CalcularSiTieneTanto()
        {
            if (Cartas[0].PaloCarta == Cartas[1].PaloCarta || Cartas[0].PaloCarta == Cartas[2].PaloCarta || Cartas[1].PaloCarta == Cartas[2].PaloCarta)
            {
                return true;
            }

            return false;
        }

        public int CalcularTantoDoble()
        {
            int tanto = 20;

            if (Cartas[0].PaloCarta == Cartas[1].PaloCarta)
            {
                tanto += Cartas[0].PuntajeTanto + Cartas[1].PuntajeTanto;
            }
            else if (Cartas[0].PaloCarta == Cartas[2].PaloCarta)
            {
                tanto += Cartas[0].PuntajeTanto + Cartas[2].PuntajeTanto;
            }
            else if (Cartas[1].PaloCarta == Cartas[2].PaloCarta)
            {
                tanto += Cartas[1].PuntajeTanto + Cartas[2].PuntajeTanto;
            }

            return tanto;
        }

        private double CalcularTantoSoloFiguras()
        {
            double tanto = 0.25;
            int aux = 0;

            foreach (Carta c in Cartas)
            {
                if (c.ValorCarta > aux)
                {
                    aux = c.ValorCarta;
                }
            }

            if (aux == 12)
            {
                tanto = 0.75;
            }
            else if (aux == 11)
            {
                tanto = 0.5;
            }

            return tanto;
        }

        #endregion

        #region ORDENAMIENTO Y VALIDEZ

        public int OrdenamientoPorValor(Carta n1, Carta n2)
        {
            int ret = 1;

            if (n1.ValorCarta == n2.ValorCarta)
            {
                ret = 0;
            }
            else if (n1.ValorCarta > n2.ValorCarta)
            {
                ret = -1;
            }

            return ret;
        }

        public bool ValidarCarta(Carta carta)
        {
            foreach (Carta c in cartas)
            {
                if (c == carta)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region OPERADORES

        public static bool operator ==(Mano manoUno, Mano manoDos)
        {
            foreach (Carta cartaPrimerMano in manoUno.cartas)
            {
                foreach (Carta cartaSegundaMano in manoDos.cartas)
                {
                    if (cartaPrimerMano == cartaSegundaMano)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Mano manoUno, Mano manoDos)
        {
            return !(manoUno == manoDos);
        }

        #endregion

        #region REPRESENTACION Y COMPARACION

        public override bool Equals(object obj)
        {
            bool ret = false;

            if (this is null && obj is null)
            {
                ret = true;
            }
            else if (obj is not null && obj is Mano && this is not null)
            {
                ret = this == (Mano)obj;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carta item in this.cartas)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("******///******");

            return sb.ToString();
        }

        #endregion
    }
}
