using Biblioteca_Truco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Truco
{
    public partial class FrmMesaTruco : Form
    {
        #region ATRIBUTOS

        private Partida partida;
        private Control[] controlesJugadorUno;
        private Control[] controlesJugadorDos;
        private RadioButton[] cartasManoJugadorUno;
        private RadioButton[] cartasManoJugadorDos;
        private Label[] naipesMesaJugador1;
        private Label[] naipesMesaJugador2;

        #endregion

        public FrmMesaTruco(Jugador jugadorUno, Jugador jugadorDos)
        {
            InitializeComponent();
            this.partida = new Partida(jugadorUno, jugadorDos);
            this.controlesJugadorUno = new Control[10] { this.btnJugarUno, this.btnEnvidoUno, this.btnFlorUno, this.btnRealEnvidoUno, this.btnTrucoUno, this.btnFaltaEnvidoUno, this.btnQuieroUno, this.btnIrseUno, this.chbOcultarUno, this.lblCantoJugador1 };
            this.controlesJugadorDos = new Control[10] { this.btnJugarDos, this.btnEnvidoDos, this.btnFlorDos, this.btnRealEnvidoDos, this.btnTrucoDos, this.btnFaltaEnvidoDos, this.btnQuieroDos, this.btnIrseDos, this.chbOcultarDos, this.lblCantoJugador2 };
            this.cartasManoJugadorUno = new RadioButton[3] { this.rBtn1, this.rBtn2, this.rBtn3 };
            this.cartasManoJugadorDos = new RadioButton[3] { this.rBtn4, this.rBtn5, this.rBtn6 };
            this.naipesMesaJugador1 = new Label[3] { this.lblCarta1A, this.lblCarta2A, this.lblCarta3A };
            this.naipesMesaJugador2 = new Label[3] { this.lblCarta1B, this.lblCarta2B, this.lblCarta3B };
            Hora.frecuenciaExcedida += RefrescarHora;
        }

        private void FrmMesaTruco_Load(object sender, EventArgs e)
        {
            gbxJugadorUno.Text = partida.JugadorUno.NombreJugador;
            gbxJugadorDos.Text = partida.JugadorDos.NombreJugador;

            //Habilitando cartas
            foreach (RadioButton item in cartasManoJugadorUno)
            {
                item.Enabled = true;
            }
            foreach (RadioButton item in cartasManoJugadorDos)
            {
                item.Enabled = true;
            }

            RefrescarHora();
            VaciarControles();
        }

        #region HABILITAR Y DESHABILITAR

        private void HabilitarEnvido(Control[] controles)
        {
            if (this.partida.RondaPartida.EstadoEnvido < 2)
            {
                controles[3].Enabled = true;
                controles[5].Enabled = true;

                if (this.partida.RondaPartida.EstadoEnvido < 1)
                {
                    controles[1].Enabled = true;
                }
            }
        }

        private void MostrarPosiciones()
        {
            this.lblPosicion1.Text = this.partida.RondaPartida.MostrarPosicion(this.partida, 1);
            this.lblPosicion2.Text = this.partida.RondaPartida.MostrarPosicion(this.partida, 2);
        }

        private void MostrarCartasSeleccionadas()
        {
            foreach (RadioButton item in this.cartasManoJugadorUno)
            {
                if (item.Enabled)
                {
                    item.Checked = true;
                    break;
                }
            }
            foreach (RadioButton item in this.cartasManoJugadorDos)
            {
                if (item.Enabled)
                {
                    item.Checked = true;
                    break;
                }
            }
        }

        private void HabilitarJugador(Jugador jugador, Control[] controles)
        {
            MostrarPosiciones();
            MostrarCartasSeleccionadas();

            if (this.partida.RondaPartida.TrucoCantado)
            {
                controles[6].Enabled = true;
            }
            else if (this.partida.RondaPartida.TantoCantado && !this.partida.RondaPartida.TantoJugado)
            {
                controles[7].Text = "No quiero!";

                if (this.partida.JugadorUno.Mano.TieneFlor)
                {
                    controles[2].Enabled = true;
                }
                else
                {
                    controles[6].Enabled = true;
                    HabilitarEnvido(controles);
                }
            }
            else
            {
                if (this.partida.RondaPartida.NumeroDeTurno == 1 && !this.partida.RondaPartida.TantoJugado)
                {
                    if (jugador.Mano.TieneFlor)
                    {
                        controles[2].Enabled = true;
                    }
                    else
                    {
                        HabilitarEnvido(controles);
                    }
                }
                controles[0].Enabled = true;
            }

            controles[7].Enabled = true; //HABILITA ME VOY AL MAZO
            controles[8].Enabled = true; //HABILITA OCULTAR
            controles[9].Text = ""; //LIMPIA ETIQUETA CANTADO
        }

        private void DeshabilitarJugador(Jugador jugador, Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.Enabled = false;
            }
           ((CheckBox)controles[8]).Checked = true;
            controles[9].Enabled = true;
        }

        #endregion

        private void RefrescarHora()
        {
            try
            {
                if (this.lblFechaYHora.InvokeRequired)
                {
                    Action refrescarReloj = RefrescarHora;
                    lblFechaYHora.Invoke(refrescarReloj);
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        this.lblFechaYHora.Text = DateTime.Now.ToString("G");
                    }));
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error al refrescar la hora: " + ex.Message);
            }
        }

        private void VaciarControles()
        {
            //Vacio etiquetas de nombre a los naipes en mesa
            lblCarta1A.Text = "";
            lblCarta1B.Text = "";
            lblCarta2A.Text = "";
            lblCarta2B.Text = "";
            lblCarta3A.Text = "";
            lblCarta3B.Text = "";

            //Vacio Valores de ronda de tanto
            lblTanto.Visible = false;
            lblEnvidoUno.Text = "";
            lblEnvidoDos.Text = "";

            //Vacio las cantadas de los jugadores
            lblCantoJugador1.Text = "";
            lblCantoJugador2.Text = "";
        }

        private void chbOcultarUno_CheckedChanged(object sender, EventArgs e)
        {
            LogicaMesa.IntercambiarVisibilidad(gbxJugadorUno, partida.JugadorUno);
        }

        private void chbOcultarDos_CheckedChanged(object sender, EventArgs e)
        {
            LogicaMesa.IntercambiarVisibilidad(gbxJugadorDos, partida.JugadorDos);
        }

        private void btnCancelarJuego_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si opta por cancelar la partida, no se almacenará en la base de datos. ¿Está completamente seguro de que desea cancelar ? ", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
