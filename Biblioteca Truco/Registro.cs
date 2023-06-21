using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco
{
    public static class Registro
    {
        private static List<Mano> registroCartasPorMano;

        static Registro()
        {
            registroCartasPorMano = new List<Mano>();
            registroCartasPorMano = SerializadoraXML<List<Mano>>.DeserializarXML(registroCartasPorMano, "Registro_Cartas");
        }

        public static List<Mano> RegistroCartasPorMano
        {
            get
            {
                return registroCartasPorMano;
            }
            set
            {
                registroCartasPorMano = value;
            }
        }

        public static void Guardar()
        {
            SerializadoraXML<List<Mano>>.SerializarXML(Registro.registroCartasPorMano, "Registro_Cartas");
            {

            }
        }
    }
}
