using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Truco;
using static System.Net.Mime.MediaTypeNames;

namespace Forms_Truco
{
    public partial class FrmMesaTruco : Form, IAccionesRonda
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
            this.controlesJugadorUno = new Control[8] { btnJugarUno, btnEnvidoUno, btnRealEnvidoUno, btnTrucoUno, btnFaltaEnvidoUno, btnQuieroUno, btnIrseUno, lblCantoUno };
            this.controlesJugadorDos = new Control[8] { btnJugarDos, btnEnvidoDos, btnRealEnvidoDos, btnTrucoDos, btnFaltaEnvidoDos, btnQuieroDos, btnIrseDos, lblCantoDos };
            this.cartasManoJugadorUno = new RadioButton[3] { rBtnCartaUno, rBtnCartaDos, rBtnCartaTres };
            this.cartasManoJugadorDos = new RadioButton[3] { rBtnCartaCuatro, rBtnCartaCinco, rBtnCartaSeis };
            this.cartasMesaJugadorUno = new Label[3] { lblCarta1A, lblCarta2A, lblCarta3A };
            this.cartasMesaJugadorDos = new Label[3] { lblCarta1B, lblCarta2B, lblCarta3B };
            Hora.frecuenciaExcedida += RefrescarHora;
        }

        #region HABILITAR Y DESHABILITAR

        private void HabilitarEnvido(Control[] controles)
        {
            if (this.partida.RondaPartida.EstadoEnvido < 2)
            {
                controles[2].Enabled = true;
                controles[4].Enabled = true;

                if (this.partida.RondaPartida.EstadoEnvido < 1)
                {
                    controles[1].Enabled = true;
                }
            }
        }

        private void MostrarPosiciones()
        {
            lblPosicion1.Text = partida.RondaPartida.MostrarPosicion(partida, 1);
            lblPosicion2.Text = partida.RondaPartida.MostrarPosicion(partida, 2);
        }

        private void MostrarCartasSeleccionadas()
        {
            foreach (RadioButton item in cartasManoJugadorUno)
            {
                if (item.Enabled)
                {
                    item.Checked = true;
                    break;
                }
            }
            foreach (RadioButton item in cartasManoJugadorDos)
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
            controles[6].Text = "Me voy al mazo!";
            MostrarCartasSeleccionadas();

            if (partida.RondaPartida.ValorDelTrucoSiSeAcepta < 4 && jugador.PoseeQuiero)
            {
                controles[3].Enabled = true;
                if (partida.RondaPartida.ValorDelTrucoSiSeAcepta == 3)
                {
                    controles[3].Text = "Vale Cuatro!";
                }
                else if (partida.RondaPartida.ValorDelTrucoSiSeAcepta == 2)
                {
                    controles[3].Text = "Retruco!";
                }
                else
                {
                    controles[3].Text = "Truco!";
                }
            }

            if (partida.RondaPartida.TrucoCantado)
            {
                controles[5].Enabled = true;
            }
            else if (partida.RondaPartida.TantoCantado && !partida.RondaPartida.TantoJugado)
            {
                controles[5].Enabled = true;
                controles[6].Text = "No quiero!";
                controles[6].Enabled = true;
                HabilitarEnvido(controles);
            }
            else
            {
                if (partida.RondaPartida.NumeroDeTurno == 1 && !partida.RondaPartida.TantoJugado)
                {
                    HabilitarEnvido(controles);
                }
                controles[0].Enabled = true;
            }

            controles[6].Enabled = true; //HABILITA ME VOY AL MAZO
            controles[7].Text = ""; //LIMPIA ETIQUETA CANTADO
        }

        private void DeshabilitarJugador(Jugador jugador, Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.Enabled = false;
            }
            controles[7].Enabled = true;
        }

        private void MostrarCartas(GroupBox gbx, Jugador jugador)
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

        #region LOGICA JUEGO

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
            partida.RondaPartida.CierreDeRonda();
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

        void MostrarGanadora(int ganadora)
        {
            int indiceAColorear = partida.RondaPartida.NumeroDeTurno - 1;

            if (ganadora == 1 || ganadora == 3)
            {
                cartasMesaJugadorUno[indiceAColorear].ForeColor = System.Drawing.Color.Green;
                cartasMesaJugadorUno[indiceAColorear].Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }
            if (ganadora == 2 || ganadora == 3)
            {
                cartasMesaJugadorDos[indiceAColorear].ForeColor = System.Drawing.Color.Green;
                cartasMesaJugadorDos[indiceAColorear].Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }
        }

        void AccionFinalizar()
        {
            if (partida.RondaPartida.CartaJugadorUno.ValorCarta > partida.RondaPartida.CartaJugadorDos.ValorCarta)
            {
                if (partida.RondaPartida.GanaPrimera == null)
                {
                    partida.RondaPartida.GanaPrimera = partida.JugadorUno;
                }
                partida.RondaPartida.ManosGanadasJugadorUno++;
                MostrarGanadora(1);
                partida.JugadorUno.EsSuTurno = true;
                partida.JugadorDos.EsSuTurno = false;
            }
            else if (partida.RondaPartida.CartaJugadorUno.ValorCarta < partida.RondaPartida.CartaJugadorDos.ValorCarta)
            {
                if (partida.RondaPartida.GanaPrimera == null)
                {
                    partida.RondaPartida.GanaPrimera = partida.JugadorDos;
                }
                partida.RondaPartida.ManosGanadasJugadorDos++;
                MostrarGanadora(2);
                partida.JugadorUno.EsSuTurno = false;
                partida.JugadorDos.EsSuTurno = true;
            }
            else
            {
                partida.RondaPartida.ManosGanadasJugadorUno++;
                partida.RondaPartida.ManosGanadasJugadorDos++;
                MostrarGanadora(3);
                partida.JugadorUno.EsSuTurno = partida.JugadorUno.EsJugadorMano;
                partida.JugadorDos.EsSuTurno = partida.JugadorDos.EsJugadorMano;
            }

            partida.RondaPartida.NumeroDeTurno++;
            partida.RondaPartida.CartaJugadorUno = null;
            partida.RondaPartida.CartaJugadorDos = null;
            RefrescarControles();

            int ganadas1 = partida.RondaPartida.ManosGanadasJugadorUno;
            int ganadas2 = partida.RondaPartida.ManosGanadasJugadorDos;

            if (ganadas1 > ganadas2 && ganadas1 >= 2)
            {
                partida.RondaPartida.GanadorTruco = partida.JugadorUno;
                CierreDeRonda();
            }
            else if (ganadas2 > ganadas1 && ganadas2 >= 2)
            {
                partida.RondaPartida.GanadorTruco = partida.JugadorDos;
                CierreDeRonda();
            }
            else if (ganadas1 == 2 && ganadas2 == 2)
            {
                if (partida.RondaPartida.GanaPrimera is not null)
                {
                    partida.RondaPartida.GanadorTruco = partida.RondaPartida.GanaPrimera;
                    CierreDeRonda();
                }
            }
            else if (ganadas1 == 3 && ganadas2 == 3)
            {
                if (partida.JugadorUno.EsJugadorMano)
                {
                    partida.RondaPartida.GanadorTruco = this.partida.JugadorUno;
                }
                else
                {
                    partida.RondaPartida.GanadorTruco = this.partida.JugadorDos;
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

        private void GuardarCantante(Jugador jugadorCantante)
        {
            if (!partida.RondaPartida.TantoCantado && !partida.RondaPartida.TrucoCantado)
            {
                partida.RondaPartida.Canto = jugadorCantante;
            }
        }

        void RefrescarTantos()
        {
            lblTanto.Visible = true;
            lblEnvidoUno.Text = partida.JugadorUno.Mano.Tanto.ToString();
            lblEnvidoDos.Text = partida.JugadorDos.Mano.Tanto.ToString();

            if (partida.JugadorUno.Mano.Tanto > partida.JugadorDos.Mano.Tanto || partida.JugadorUno.EsJugadorMano && partida.JugadorUno.Mano.Tanto == partida.JugadorDos.Mano.Tanto)
            {
                lblEnvidoUno.ForeColor = System.Drawing.Color.Green;
                lblEnvidoUno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }
            else
            {
                lblEnvidoDos.ForeColor = System.Drawing.Color.Green;
                lblEnvidoDos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }
            RefrescarControles();
        }

        public void Aceptar(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (partida.RondaPartida.TantoCantado)
            {
                RefrescarTantos();
            }
            partida.RondaPartida.Aceptar(jugadorUno, jugadorDos);

            while (!partida.RondaPartida.Canto.EsSuTurno) // retorna al turno del jugador que inició un canto luego de que este se definiera
            {
                AccionCambiar();
            }
            RefrescarControles();
        }

        public void Rechazar(Jugador jugadorCantante)
        {
            partida.RondaPartida.Rechazar(jugadorCantante);
            if (!partida.RondaPartida.TantoCantado)
            {
                CierreDeRonda();
            }
            else
            {
                AccionCambiar();
                partida.RondaPartida.TantoCantado = false;
            }
            RefrescarControles();
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

            MostrarCartas(gbxJugadorUno, partida.JugadorUno);
            MostrarCartas(gbxJugadorDos, partida.JugadorDos);
            RefrescarControles();
            RefrescarHora();
            VaciarControles();
        }

        private void btnCancelarJuego_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si opta por cancelar la partida, no se almacenará en la base de datos. ¿Está completamente seguro de que desea cancelar ? ", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Close();
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

        private void btnEnvidoUno_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorUno);
            partida.RondaPartida.ReavivarEnvido(0, 2);
            lblCantoUno.Text = "¡Te canto Envido!";
            AccionCambiar();
        }

        private void btnEnvidoDos_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorDos);
            partida.RondaPartida.ReavivarEnvido(0, 2);
            lblCantoDos.Text = "¡Te canto Envido!";
            AccionCambiar();
        }

        private void btnRealEnvidoUno_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorUno);
            partida.RondaPartida.ReavivarEnvido(1, 3);
            lblCantoUno.Text = "¡Real Envido compa!";
            AccionCambiar();
        }

        private void btnRealEnvidoDos_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorDos);
            partida.RondaPartida.ReavivarEnvido(1, 3);
            lblCantoDos.Text = "¡Real Envido compa!";
            AccionCambiar();
        }

        private void btnFaltaEnvidoUno_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorUno);
            partida.RondaPartida.ReavivarEnvido(partida);
            lblCantoUno.Text = "Falta Envido!";
            AccionCambiar();
        }

        private void btnFaltaEnvidoDos_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorDos);
            partida.RondaPartida.ReavivarEnvido(partida);
            lblCantoDos.Text = "Falta Envido!";
            AccionCambiar();
        }

        private void btnTrucoUno_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorUno);
            partida.RondaPartida.Retrucar(partida.JugadorUno, partida.JugadorDos);
            lblCantoUno.Text = btnTrucoUno.Text;
            AccionCambiar();
        }

        private void btnTrucoDos_Click(object sender, EventArgs e)
        {
            GuardarCantante(partida.JugadorDos);
            partida.RondaPartida.Retrucar(partida.JugadorDos, partida.JugadorUno);
            lblCantoDos.Text = btnTrucoDos.Text;
            AccionCambiar();
        }

        private void btnQuieroUno_Click(object sender, EventArgs e)
        {
            Aceptar(partida.JugadorUno, partida.JugadorDos);
        }

        private void btnQuieroDos_Click(object sender, EventArgs e)
        {
            Aceptar(partida.JugadorDos, partida.JugadorUno);
        }

        private void btnIrseUno_Click(object sender, EventArgs e)
        {
            Rechazar(partida.JugadorDos);
        }

        private void btnIrseDos_Click(object sender, EventArgs e)
        {
            Rechazar(partida.JugadorUno);
        }

        #endregion
    }
}
