using Biblioteca_Truco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Truco
{
    public static class LogicaMesa
    {
        private static void OcultarCartas(GroupBox gbx)
        {
            foreach (object item in gbx.Controls)
            {
                if (item is RadioButton)
                {
                    ((RadioButton)item).Text = "";
                }
            }
        }

        private static void MostrarCartas(GroupBox gbx, Jugador jugador)
        {
            int i = 0;
            foreach (object item in gbx.Controls)
            {
                if (item is RadioButton)
                {
                    ((RadioButton)item).Text = jugador.Mano.Cartas[i].ToString();
                    i++;
                }
            }
        }

        public static void IntercambiarVisibilidad(GroupBox gbx, Jugador jugador)
        {
            foreach (object item in gbx.Controls)
            {
                if (item is CheckBox)
                {
                    if (((CheckBox)item).Checked)
                    {
                        OcultarCartas(gbx);
                    }
                    else
                    {
                        MostrarCartas(gbx, jugador);
                    }
                    break;
                }
            }
        }
    }
}
