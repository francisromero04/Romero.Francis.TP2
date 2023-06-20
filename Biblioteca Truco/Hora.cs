using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca_Truco
{
    public static class Hora
    {
        public delegate void DelegadoHora();
        private static int frecuenciaDeActualización;
        private static Task ejecucion;
        public static event DelegadoHora frecuenciaExcedida;

        static Hora()
        {
            frecuenciaDeActualización = 1000;
            ejecucion = new Task(ActualizarHora);
            ejecucion.Start();
        }

        public static void ActualizarHora()
        {
            bool infinito = true;

            while (infinito)
            {
                DelegadoHora handler = frecuenciaExcedida; // Almacenar en una variable local para evitar race conditions

                if (handler != null)
                {
                    handler.Invoke(); // Invocar el evento solo si hay suscriptores
                }

                Thread.Sleep(frecuenciaDeActualización);
            }
        }
    }
}
