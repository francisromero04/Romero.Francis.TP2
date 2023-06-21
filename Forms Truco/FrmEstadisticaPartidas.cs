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
    public partial class FrmEstadisticaPartidas : Form
    {
        public FrmEstadisticaPartidas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaPartidas_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataSource = new DataTable();

                dataSource.Load(ConexionSQL.Leer());
                dataGridViewEstadistica.DataSource = dataSource;

            }
            catch (ExcepcionConectar excepcion)
            {
                MessageBox.Show(excepcion.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionSQL.CerrarConexion();
            }
        }
    }
}
