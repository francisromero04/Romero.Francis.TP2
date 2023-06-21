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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instancia una nueva mesa de Truco Simulador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrearPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearMesa set = new FrmCrearMesa();
            set.MdiParent = this;
            set.Show();
        }

        private void historialDeResultadosSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadisticaPartidas formulario = new FrmEstadisticaPartidas();
            formulario.ShowDialog();
        }
    }
}
