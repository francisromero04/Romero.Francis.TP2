using Biblioteca_Truco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Truco
{
    public partial class FrmEstadisticaCartasPorMano : Form
    {
        public FrmEstadisticaCartasPorMano()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaCartasPorMano_Load(object sender, EventArgs e)
        {
            List<Mano> listaCartasPorMano = new List<Mano>();
            StringBuilder sb = new StringBuilder();

            listaCartasPorMano = SerializadoraXML<List<Mano>>.DeserializarXML(listaCartasPorMano, "Registro_Cartas");

            foreach (Mano item in listaCartasPorMano)
            {
                sb.Append(item.ToString());
            }

            richTextBox1.Text = sb.ToString();
        }
    }
}
