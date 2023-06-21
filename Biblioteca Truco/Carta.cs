using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco
{
    public class Carta
    {
        #region ATRIBUTOS

        private EPalosCarta paloCarta;
        private int puntajeTanto;
        private int valorCarta;
        private int numeroCarta;

        #endregion

        public Carta(bool randomizar)
        {
            this.numeroCarta = CalcularNumeroAleatorio();
            this.puntajeTanto = CalcularValorTanto();
            this.valorCarta = CalcularValorCarta(this.numeroCarta, this.paloCarta);
            this.paloCarta = CalcularPaloAleatorio();
        }

        #region GETTERS Y SETTERS

        public EPalosCarta PaloCarta
        {
            get
            {
                return this.paloCarta;
            }
            set
            {
                this.paloCarta = value;
            }
        }

        public int NumeroCarta
        {
            get
            {
                return this.numeroCarta;
            }
            set
            {
                this.numeroCarta = value;
            }
        }

        public int PuntajeTanto
        {
            get
            {
                return this.puntajeTanto;
            }
            set
            {
                this.puntajeTanto = value;
            }
        }

        public int ValorCarta
        {
            get
            {
                return this.valorCarta;
            }
            set
            {
                this.valorCarta = value;
            }
        }

        #endregion

        #region CALCULADORES

        private int CalcularValorCarta(int numeroCarta, EPalosCarta paloCarta)
        {
            int ret = numeroCarta;

            if (numeroCarta < 4)
            {
                ret += 12;
            }

            switch (paloCarta)
            {
                case EPalosCarta.Oro:
                    if (numeroCarta == 7)
                    {
                        ret = 16;
                    }
                    break;

                case EPalosCarta.Basto:
                    if (numeroCarta == 1)
                    {
                        ret = 18;
                    }
                    break;

                case EPalosCarta.Espada:
                    if (numeroCarta == 1)
                    {
                        ret = 19;
                    }
                    else if (numeroCarta == 7)
                    {
                        ret = 17;
                    }
                    break;

            }
            return ret;
        }

        public int CalcularValorTanto()
        {
            if (this.NumeroCarta <= 7)
            {
                return NumeroCarta;
            }

            return 0;  // Valor predeterminado cuando la condición no se cumple (0)
        }

        private static int CalcularNumeroAleatorio()
        {
            int numero;
            Random random = new Random();

            do
            {
                numero = random.Next(1, 13);
            } while (numero == 8 || numero == 9);

            return numero;
        }

        public static EPalosCarta CalcularPaloAleatorio()
        {
            EPalosCarta[] palos = (EPalosCarta[])Enum.GetValues(typeof(EPalosCarta));
            Random random = new Random();
            EPalosCarta palo = palos[random.Next(palos.Length)];

            return palo;
        }

        #endregion

        #region OPERADORES

        public static bool operator == (Carta cartaUno, Carta cartaDos)
        {
            return cartaUno.numeroCarta == cartaDos.numeroCarta && cartaUno.paloCarta == cartaDos.paloCarta;
        }

        public static bool operator != (Carta cartaUno, Carta cartaDos)
        {
            return !(cartaUno == cartaDos);
        }

        #endregion

        #region REPRESENTACION Y COMPARACION

        public override bool Equals(object obj)
        {
            if (obj is Carta carta)
            {
                return this == carta;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.numeroCarta} de {this.paloCarta.ToString()}";
        }

        #endregion
    }
}
