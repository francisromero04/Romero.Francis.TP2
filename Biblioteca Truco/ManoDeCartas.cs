using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco
{
    public class ManoDeCartas<T> : IEnumerable<T>
    {
        private List<T> cartas;

        public ManoDeCartas()
        {
            cartas = new List<T>();
        }

        public void AgregarCarta(T carta)
        {
            cartas.Add(carta);
        }

        public void RemoverCarta(T carta)
        {
            cartas.Remove(carta);
        }

        public T ObtenerCarta(int indice)
        {
            if (indice >= 0 && indice < cartas.Count)
            {
                return cartas[indice];
            }
            else
            {
                throw new IndexOutOfRangeException("Índice de carta fuera de rango.");
            }
        }

        public int CantidadDeCartas()
        {
            return cartas.Count;
        }

        public void OrdenarPorValor(Comparison<T> comparison)
        {
            cartas.Sort(comparison);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return cartas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cartas.GetEnumerator();
        }

        public T this[int indice] //accede a una lista por un indice, 'transformamos' nuestra lista en un array list, por el indice
        {
            get
            {
                return ObtenerCarta(indice);
            }
        }

        public void Add(object objeto) //metodo incorporado por error en ejecucion
        {
            if (objeto is T)
            {
                T carta = (T)objeto;
                AgregarCarta(carta);
            }
            else
            {
                throw new ArgumentException("El objeto no es del tipo esperado.");
            }
        }
    }
}
