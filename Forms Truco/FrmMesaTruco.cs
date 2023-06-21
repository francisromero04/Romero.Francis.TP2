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
using static System.Net.Mime.MediaTypeNames;

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
        private Label[] cartasMesaJugadorUno;
        private Label[] cartasMesaJugadorDos;

        #endregion

        public FrmMesaTruco(Jugador jugadorUno, Jugador jugadorDos)
        {
            InitializeComponent();
            this.partida = new Partida(jugadorUno, jugadorDos);
            this.controlesJugadorUno = new Control[9] { this.btnJugarUno, this.btnEnvidoUno, this.btnFlorUno, this.btnRealEnvidoUno, this.btnTrucoUno, this.btnFaltaEnvidoUno, this.btnQuieroUno, this.btnIrseUno, this.lblCantoUno };
            this.controlesJugadorDos = new Control[9] { this.btnJugarDos, this.btnEnvidoDos, this.btnFlorDos, this.btnRealEnvidoDos, this.btnTrucoDos, this.btnFaltaEnvidoDos, this.btnQuieroDos, this.btnIrseDos, this.lblCantoDos };
            this.cartasManoJugadorUno = new RadioButton[3] { this.rBtnCartaUno, this.rBtnCartaDos, this.rBtnCartaTres };
            this.cartasManoJugadorDos = new RadioButton[3] { this.rBtnCartaCuatro, this.rBtnCartaCinco, this.rBtnCartaSeis };
            this.cartasMesaJugadorUno = new Label[3] { this.lblCarta1A, this.lblCarta2A, this.lblCarta3A };
            this.cartasMesaJugadorDos = new Label[3] { this.lblCarta1B, this.lblCarta2B, this.lblCarta3B };
            Hora.frecuenciaExcedida += RefrescarHora;
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
            controles[8].Text = ""; //LIMPIA ETIQUETA CANTADO
        }

        private void DeshabilitarJugador(Jugador jugador, Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.Enabled = false;
            }
            controles[8].Enabled = true;
        }

        #endregion

        #region ACTUALIZADORES

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
            lblCantoUno.Text = "";
            lblCantoDos.Text = "";
        }

        private void RefrescarControles()
        {
            lblValorDelTruco.Text = $"Valor del Truco: {partida.RondaPartida.ValorDelTrucoActual}";
            lblValorTanto.Text = $"Valor del Tanto: {partida.RondaPartida.ValorDelTantoActual}";

            if (partida.JugadorUno.EsSuTurno)
            {
                DeshabilitarJugador(partida.JugadorUno, controlesJugadorUno);
                DeshabilitarJugador(partida.JugadorDos, controlesJugadorDos);
                HabilitarJugador(partida.JugadorUno, controlesJugadorUno);
            }
            else
            {
                DeshabilitarJugador(partida.JugadorUno, controlesJugadorUno);
                DeshabilitarJugador(partida.JugadorDos, controlesJugadorDos);
                HabilitarJugador(partida.JugadorDos, controlesJugadorDos);
            }
        }

        #endregion

        #region LOGICA JUGAR

        private void JugarCarta(Carta carta)
        {
            switch (partida.RondaPartida.NumeroDeTurno)
            {
                case 1:
                    if (partida.JugadorUno.EsSuTurno)
                    {
                        lblCarta1A.Text = carta.ToString();
                    }
                    else
                    {
                        lblCarta1B.Text = carta.ToString();
                    }
                    break;
                case 2:
                    if (partida.JugadorUno.EsSuTurno)
                    {
                        lblCarta2A.Text = carta.ToString();
                    }
                    else
                    {
                        lblCarta2B.Text = carta.ToString();
                    }
                    break;
                case 3:
                    if (partida.JugadorUno.EsSuTurno)
                    {
                        lblCarta3A.Text = carta.ToString();
                    }
                    else
                    {
                        lblCarta3B.Text = carta.ToString();
                    }
                    break;
            }
        }

        private Carta ObtenerCartaSeleccionada(Jugador jugador, RadioButton[] cartas)
        {
            Carta cartaSeleccionada = null;
            int indiceSeleccionado = -1;

            for (int i = 0; i < cartas.Length; i++)
            {
                if (cartas[i].Checked)
                {
                    indiceSeleccionado = i;
                    break;
                }
            }

            if (indiceSeleccionado != -1)
            {
                cartaSeleccionada = jugador.Mano.Cartas[indiceSeleccionado];
                JugarCarta(cartaSeleccionada);
                cartas[indiceSeleccionado].Enabled = false;
            }

            return cartaSeleccionada;
        }

        private void InformarResultado()
        {
            if (MessageBox.Show(partida.ToString(), "Resultado Partida", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    ConexionSQL.GuardarPartidaSQL(partida);
                    Close();
                }
                catch (ExcepcionConectar ex)
                {
                    MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CierreDeRonda()
        {
            partida.RondaPartida.FinalizarRonda();
            MessageBox.Show(partida.RondaPartida.ToString(), "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarControles();

            if (partida.PartidaTerminada)
            {
                InformarResultado();
                return;
            }

            partida.ProximaRonda();
            FrmMesaTruco_Load(this, EventArgs.Empty);
        }

        void EvaluarGanadorTurno()
        {
            int valorCartaJugadorUno = partida.RondaPartida.CartaJugadorUno is not null ? partida.RondaPartida.CartaJugadorUno.ValorCarta : 0;
            int valorCartaJugadorDos = partida.RondaPartida.CartaJugadorDos is not null ? partida.RondaPartida.CartaJugadorDos.ValorCarta : 0;

            if (valorCartaJugadorUno > valorCartaJugadorDos)
            {
                if (partida.RondaPartida.GanaPrimera == null)
                {
                    partida.RondaPartida.GanaPrimera = partida.JugadorUno;
                }

                partida.RondaPartida.ManosGanadasJugadorUno++;
                partida.JugadorUno.EsSuTurno = true;
                partida.JugadorDos.EsSuTurno = false;
            }
            else if (valorCartaJugadorUno < valorCartaJugadorDos)
            {
                if (partida.RondaPartida.GanaPrimera == null)
                {
                    partida.RondaPartida.GanaPrimera = partida.JugadorDos;
                }

                partida.RondaPartida.ManosGanadasJugadorDos++;
                partida.JugadorUno.EsSuTurno = false;
                partida.JugadorDos.EsSuTurno = true;
            }
            else
            {
                partida.RondaPartida.ManosGanadasJugadorUno++;
                partida.RondaPartida.ManosGanadasJugadorDos++;
                partida.JugadorUno.EsSuTurno = partida.JugadorUno.EsJugadorMano;
                partida.JugadorDos.EsSuTurno = partida.JugadorDos.EsJugadorMano;
            }
        }

        void AccionFinalizar()
        {
            EvaluarGanadorTurno();
            partida.RondaPartida.NumeroDeTurno++;
            partida.RondaPartida.CartaJugadorUno = null;
            partida.RondaPartida.CartaJugadorDos = null;

            RefrescarControles();

            int cantidadVictoriasUno = partida.RondaPartida.ManosGanadasJugadorUno;
            int cantidadVictoriasDos = partida.RondaPartida.ManosGanadasJugadorDos;

            if (cantidadVictoriasUno >= 2 && cantidadVictoriasUno > cantidadVictoriasDos)
            {
                partida.RondaPartida.GanadorTruco = partida.JugadorUno;
                CierreDeRonda();
                return;
            }

            if (cantidadVictoriasDos >= 2 && cantidadVictoriasDos > cantidadVictoriasUno)
            {
                partida.RondaPartida.GanadorTruco = partida.JugadorDos;
                CierreDeRonda();
                return;
            }

            if (cantidadVictoriasUno == 2 && cantidadVictoriasDos == 2 && partida.RondaPartida.GanaPrimera != null)
            {
                partida.RondaPartida.GanadorTruco = partida.RondaPartida.GanaPrimera;
                CierreDeRonda();
                return;
            }

            if (cantidadVictoriasUno == 3 && cantidadVictoriasDos == 3)
            {
                if (partida.JugadorUno.EsJugadorMano)
                {
                    partida.RondaPartida.GanadorTruco = partida.JugadorUno;
                }
                else
                {
                    partida.RondaPartida.GanadorTruco = partida.JugadorDos;
                }
                CierreDeRonda();
            }
        }

        private void AccionCambiar()
        {
            //Si es el turno del jugador 1 cambio al jugador 2 y vice versa, seteando las opciones disponibles según corresponda
            if (partida.JugadorUno.EsSuTurno)
            {
                partida.JugadorUno.EsSuTurno = false;
                partida.JugadorDos.EsSuTurno = true;
                RefrescarControles();
            }
            else
            {
                partida.JugadorUno.EsSuTurno = true;
                partida.JugadorDos.EsSuTurno = false;
                RefrescarControles();
            }
        }

        private void AccionesTurnoMesa()
        {
            if (partida.RondaPartida.CartaJugadorUno is not null && partida.RondaPartida.CartaJugadorDos is not null)
            {
                AccionFinalizar();
            }
            else
            {
                AccionCambiar();
            }
        }

        #endregion

        #region EVENTOS

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

        private void btnCancelarJuego_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si opta por cancelar la partida, no se almacenará en la base de datos. ¿Está completamente seguro de que desea cancelar ? ", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnJugarUno_Click(object sender, EventArgs e)
        {
            partida.RondaPartida.CartaJugadorUno = ObtenerCartaSeleccionada(partida.JugadorUno, cartasManoJugadorUno);

            if (partida.RondaPartida.CartaJugadorUno is not null)
            {
                AccionesTurnoMesa();
            }
        }

        private void btnJugarDos_Click(object sender, EventArgs e)
        {
            partida.RondaPartida.CartaJugadorDos = ObtenerCartaSeleccionada(partida.JugadorDos, cartasManoJugadorDos);

            if (partida.RondaPartida.CartaJugadorDos is not null)
            {
                AccionesTurnoMesa();
            }
        }

        #endregion
    }
}
