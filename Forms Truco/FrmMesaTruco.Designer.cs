namespace Forms_Truco
{
    partial class FrmMesaTruco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFechaYHora = new Label();
            lblCantoDos = new Label();
            lblCantoUno = new Label();
            btnCancelarJuego = new Button();
            gbxPosiciones = new GroupBox();
            lblPosicion2 = new Label();
            lblPosicion1 = new Label();
            gbxMesa = new GroupBox();
            lblEnvidoDos = new Label();
            lblEnvidoUno = new Label();
            lblTanto = new Label();
            lblValorDelTruco = new Label();
            lblCarta3B = new Label();
            lblValorTanto = new Label();
            lblCarta3A = new Label();
            lblMano3 = new Label();
            lblCarta2B = new Label();
            lblCarta2A = new Label();
            lblMano2 = new Label();
            lblCarta1B = new Label();
            lblCarta1A = new Label();
            lblMano1 = new Label();
            btnIrseDos = new Button();
            btnQuieroDos = new Button();
            btnTrucoDos = new Button();
            btnFlorDos = new Button();
            btnFaltaEnvidoDos = new Button();
            btnRealEnvidoDos = new Button();
            btnEnvidoDos = new Button();
            btnIrseUno = new Button();
            gbxJugadorDos = new GroupBox();
            btnJugarDos = new Button();
            rBtnCartaCuatro = new RadioButton();
            rBtnCartaCinco = new RadioButton();
            rBtnCartaSeis = new RadioButton();
            gbxJugadorUno = new GroupBox();
            btnJugarUno = new Button();
            rBtnCartaUno = new RadioButton();
            rBtnCartaDos = new RadioButton();
            rBtnCartaTres = new RadioButton();
            btnQuieroUno = new Button();
            btnTrucoUno = new Button();
            btnFlorUno = new Button();
            btnFaltaEnvidoUno = new Button();
            btnRealEnvidoUno = new Button();
            btnEnvidoUno = new Button();
            gbxPosiciones.SuspendLayout();
            gbxMesa.SuspendLayout();
            gbxJugadorDos.SuspendLayout();
            gbxJugadorUno.SuspendLayout();
            SuspendLayout();
            // 
            // lblFechaYHora
            // 
            lblFechaYHora.Location = new Point(400, 466);
            lblFechaYHora.Name = "lblFechaYHora";
            lblFechaYHora.Size = new Size(176, 15);
            lblFechaYHora.TabIndex = 36;
            lblFechaYHora.Text = "Hora";
            lblFechaYHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCantoDos
            // 
            lblCantoDos.AutoSize = true;
            lblCantoDos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantoDos.Location = new Point(400, 394);
            lblCantoDos.Name = "lblCantoDos";
            lblCantoDos.Size = new Size(151, 25);
            lblCantoDos.TabIndex = 49;
            lblCantoDos.Text = "Falta Envido!";
            // 
            // lblCantoUno
            // 
            lblCantoUno.AutoSize = true;
            lblCantoUno.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantoUno.Location = new Point(12, 394);
            lblCantoUno.Name = "lblCantoUno";
            lblCantoUno.Size = new Size(151, 25);
            lblCantoUno.TabIndex = 48;
            lblCantoUno.Text = "Falta Envido!";
            // 
            // btnCancelarJuego
            // 
            btnCancelarJuego.Location = new Point(194, 430);
            btnCancelarJuego.Name = "btnCancelarJuego";
            btnCancelarJuego.Size = new Size(200, 48);
            btnCancelarJuego.TabIndex = 47;
            btnCancelarJuego.Text = "Cancelar Partida";
            btnCancelarJuego.UseVisualStyleBackColor = true;
            btnCancelarJuego.Click += btnCancelarJuego_Click;
            // 
            // gbxPosiciones
            // 
            gbxPosiciones.Controls.Add(lblPosicion2);
            gbxPosiciones.Controls.Add(lblPosicion1);
            gbxPosiciones.Location = new Point(194, 352);
            gbxPosiciones.Name = "gbxPosiciones";
            gbxPosiciones.Size = new Size(200, 72);
            gbxPosiciones.TabIndex = 46;
            gbxPosiciones.TabStop = false;
            gbxPosiciones.Text = "Posiciones";
            // 
            // lblPosicion2
            // 
            lblPosicion2.AutoSize = true;
            lblPosicion2.Location = new Point(7, 42);
            lblPosicion2.Name = "lblPosicion2";
            lblPosicion2.Size = new Size(61, 15);
            lblPosicion2.TabIndex = 1;
            lblPosicion2.Text = "Posición 2";
            // 
            // lblPosicion1
            // 
            lblPosicion1.AutoSize = true;
            lblPosicion1.Location = new Point(7, 23);
            lblPosicion1.Name = "lblPosicion1";
            lblPosicion1.Size = new Size(61, 15);
            lblPosicion1.TabIndex = 0;
            lblPosicion1.Text = "Posición 1";
            // 
            // gbxMesa
            // 
            gbxMesa.Controls.Add(lblEnvidoDos);
            gbxMesa.Controls.Add(lblEnvidoUno);
            gbxMesa.Controls.Add(lblTanto);
            gbxMesa.Controls.Add(lblValorDelTruco);
            gbxMesa.Controls.Add(lblCarta3B);
            gbxMesa.Controls.Add(lblValorTanto);
            gbxMesa.Controls.Add(lblCarta3A);
            gbxMesa.Controls.Add(lblMano3);
            gbxMesa.Controls.Add(lblCarta2B);
            gbxMesa.Controls.Add(lblCarta2A);
            gbxMesa.Controls.Add(lblMano2);
            gbxMesa.Controls.Add(lblCarta1B);
            gbxMesa.Controls.Add(lblCarta1A);
            gbxMesa.Controls.Add(lblMano1);
            gbxMesa.Location = new Point(194, 10);
            gbxMesa.Name = "gbxMesa";
            gbxMesa.Size = new Size(200, 327);
            gbxMesa.TabIndex = 45;
            gbxMesa.TabStop = false;
            gbxMesa.Text = "Mesa";
            // 
            // lblEnvidoDos
            // 
            lblEnvidoDos.Location = new Point(104, 221);
            lblEnvidoDos.Name = "lblEnvidoDos";
            lblEnvidoDos.Size = new Size(90, 15);
            lblEnvidoDos.TabIndex = 13;
            lblEnvidoDos.Text = "Tanto Jugador 2";
            lblEnvidoDos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEnvidoUno
            // 
            lblEnvidoUno.AutoSize = true;
            lblEnvidoUno.Location = new Point(6, 221);
            lblEnvidoUno.Name = "lblEnvidoUno";
            lblEnvidoUno.Size = new Size(90, 15);
            lblEnvidoUno.TabIndex = 12;
            lblEnvidoUno.Text = "Tanto Jugador 1";
            // 
            // lblTanto
            // 
            lblTanto.AutoSize = true;
            lblTanto.Location = new Point(83, 196);
            lblTanto.Name = "lblTanto";
            lblTanto.Size = new Size(36, 15);
            lblTanto.TabIndex = 11;
            lblTanto.Text = "Tanto";
            // 
            // lblValorDelTruco
            // 
            lblValorDelTruco.AutoSize = true;
            lblValorDelTruco.Location = new Point(6, 302);
            lblValorDelTruco.Name = "lblValorDelTruco";
            lblValorDelTruco.Size = new Size(96, 15);
            lblValorDelTruco.TabIndex = 1;
            lblValorDelTruco.Text = "Valor del Truco: 1";
            // 
            // lblCarta3B
            // 
            lblCarta3B.Location = new Point(113, 168);
            lblCarta3B.Name = "lblCarta3B";
            lblCarta3B.Size = new Size(81, 15);
            lblCarta3B.TabIndex = 10;
            lblCarta3B.Text = "Carta 3B";
            lblCarta3B.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValorTanto
            // 
            lblValorTanto.AutoSize = true;
            lblValorTanto.Location = new Point(6, 283);
            lblValorTanto.Name = "lblValorTanto";
            lblValorTanto.Size = new Size(103, 15);
            lblValorTanto.TabIndex = 0;
            lblValorTanto.Text = "Valor del Envido: 0";
            // 
            // lblCarta3A
            // 
            lblCarta3A.AutoSize = true;
            lblCarta3A.Location = new Point(7, 168);
            lblCarta3A.Name = "lblCarta3A";
            lblCarta3A.Size = new Size(52, 15);
            lblCarta3A.TabIndex = 9;
            lblCarta3A.Text = "Carta 3A";
            // 
            // lblMano3
            // 
            lblMano3.AutoSize = true;
            lblMano3.Location = new Point(62, 141);
            lblMano3.Name = "lblMano3";
            lblMano3.Size = new Size(78, 15);
            lblMano3.TabIndex = 8;
            lblMano3.Text = "Tercera Mano";
            // 
            // lblCarta2B
            // 
            lblCarta2B.Location = new Point(113, 105);
            lblCarta2B.Name = "lblCarta2B";
            lblCarta2B.Size = new Size(81, 15);
            lblCarta2B.TabIndex = 7;
            lblCarta2B.Text = "Carta 2B";
            lblCarta2B.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCarta2A
            // 
            lblCarta2A.AutoSize = true;
            lblCarta2A.Location = new Point(7, 105);
            lblCarta2A.Name = "lblCarta2A";
            lblCarta2A.Size = new Size(52, 15);
            lblCarta2A.TabIndex = 6;
            lblCarta2A.Text = "Carta 2A";
            // 
            // lblMano2
            // 
            lblMano2.AutoSize = true;
            lblMano2.Location = new Point(58, 80);
            lblMano2.Name = "lblMano2";
            lblMano2.Size = new Size(87, 15);
            lblMano2.TabIndex = 5;
            lblMano2.Text = "Segunda Mano";
            // 
            // lblCarta1B
            // 
            lblCarta1B.Location = new Point(113, 46);
            lblCarta1B.Name = "lblCarta1B";
            lblCarta1B.Size = new Size(81, 15);
            lblCarta1B.TabIndex = 4;
            lblCarta1B.Text = "Carta 1B";
            lblCarta1B.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCarta1A
            // 
            lblCarta1A.AutoSize = true;
            lblCarta1A.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarta1A.ForeColor = SystemColors.ControlText;
            lblCarta1A.Location = new Point(7, 46);
            lblCarta1A.Name = "lblCarta1A";
            lblCarta1A.Size = new Size(52, 15);
            lblCarta1A.TabIndex = 3;
            lblCarta1A.Text = "Carta 1A";
            // 
            // lblMano1
            // 
            lblMano1.AutoSize = true;
            lblMano1.Location = new Point(63, 19);
            lblMano1.Name = "lblMano1";
            lblMano1.Size = new Size(82, 15);
            lblMano1.TabIndex = 2;
            lblMano1.Text = "Primera Mano";
            // 
            // btnIrseDos
            // 
            btnIrseDos.BackColor = SystemColors.ActiveBorder;
            btnIrseDos.Location = new Point(400, 314);
            btnIrseDos.Name = "btnIrseDos";
            btnIrseDos.Size = new Size(176, 23);
            btnIrseDos.TabIndex = 44;
            btnIrseDos.Text = "Me voy al mazo";
            btnIrseDos.UseVisualStyleBackColor = false;
            // 
            // btnQuieroDos
            // 
            btnQuieroDos.BackColor = SystemColors.ActiveBorder;
            btnQuieroDos.Location = new Point(491, 285);
            btnQuieroDos.Name = "btnQuieroDos";
            btnQuieroDos.Size = new Size(85, 23);
            btnQuieroDos.TabIndex = 43;
            btnQuieroDos.Text = "Quiero!";
            btnQuieroDos.UseVisualStyleBackColor = false;
            // 
            // btnTrucoDos
            // 
            btnTrucoDos.BackColor = SystemColors.ActiveBorder;
            btnTrucoDos.Location = new Point(491, 256);
            btnTrucoDos.Name = "btnTrucoDos";
            btnTrucoDos.Size = new Size(85, 23);
            btnTrucoDos.TabIndex = 42;
            btnTrucoDos.Text = "Truco!";
            btnTrucoDos.UseVisualStyleBackColor = false;
            // 
            // btnFlorDos
            // 
            btnFlorDos.BackColor = SystemColors.ActiveBorder;
            btnFlorDos.Location = new Point(491, 227);
            btnFlorDos.Name = "btnFlorDos";
            btnFlorDos.Size = new Size(85, 23);
            btnFlorDos.TabIndex = 41;
            btnFlorDos.Text = "Flor!";
            btnFlorDos.UseVisualStyleBackColor = false;
            // 
            // btnFaltaEnvidoDos
            // 
            btnFaltaEnvidoDos.BackColor = SystemColors.ActiveBorder;
            btnFaltaEnvidoDos.Location = new Point(400, 285);
            btnFaltaEnvidoDos.Name = "btnFaltaEnvidoDos";
            btnFaltaEnvidoDos.Size = new Size(85, 23);
            btnFaltaEnvidoDos.TabIndex = 40;
            btnFaltaEnvidoDos.Text = "Falta Envido!";
            btnFaltaEnvidoDos.UseVisualStyleBackColor = false;
            // 
            // btnRealEnvidoDos
            // 
            btnRealEnvidoDos.BackColor = SystemColors.ActiveBorder;
            btnRealEnvidoDos.Location = new Point(400, 256);
            btnRealEnvidoDos.Name = "btnRealEnvidoDos";
            btnRealEnvidoDos.Size = new Size(85, 23);
            btnRealEnvidoDos.TabIndex = 39;
            btnRealEnvidoDos.Text = "Real Envido!";
            btnRealEnvidoDos.UseVisualStyleBackColor = false;
            // 
            // btnEnvidoDos
            // 
            btnEnvidoDos.BackColor = SystemColors.ActiveBorder;
            btnEnvidoDos.Location = new Point(400, 227);
            btnEnvidoDos.Name = "btnEnvidoDos";
            btnEnvidoDos.Size = new Size(85, 23);
            btnEnvidoDos.TabIndex = 38;
            btnEnvidoDos.Text = "Envido!";
            btnEnvidoDos.UseVisualStyleBackColor = false;
            // 
            // btnIrseUno
            // 
            btnIrseUno.BackColor = SystemColors.ActiveBorder;
            btnIrseUno.Location = new Point(12, 314);
            btnIrseUno.Name = "btnIrseUno";
            btnIrseUno.Size = new Size(176, 23);
            btnIrseUno.TabIndex = 37;
            btnIrseUno.Text = "Me voy al mazo";
            btnIrseUno.UseVisualStyleBackColor = false;
            // 
            // gbxJugadorDos
            // 
            gbxJugadorDos.Controls.Add(btnJugarDos);
            gbxJugadorDos.Controls.Add(rBtnCartaCuatro);
            gbxJugadorDos.Controls.Add(rBtnCartaCinco);
            gbxJugadorDos.Controls.Add(rBtnCartaSeis);
            gbxJugadorDos.Location = new Point(400, 10);
            gbxJugadorDos.Name = "gbxJugadorDos";
            gbxJugadorDos.Size = new Size(176, 156);
            gbxJugadorDos.TabIndex = 35;
            gbxJugadorDos.TabStop = false;
            gbxJugadorDos.Text = "Jugador 2";
            // 
            // btnJugarDos
            // 
            btnJugarDos.BackColor = SystemColors.ActiveBorder;
            btnJugarDos.Location = new Point(50, 126);
            btnJugarDos.Name = "btnJugarDos";
            btnJugarDos.Size = new Size(75, 23);
            btnJugarDos.TabIndex = 27;
            btnJugarDos.Text = "Jugar carta";
            btnJugarDos.UseVisualStyleBackColor = false;
            btnJugarDos.Click += btnJugarDos_Click;
            // 
            // rBtnCartaCuatro
            // 
            rBtnCartaCuatro.AutoSize = true;
            rBtnCartaCuatro.Location = new Point(23, 32);
            rBtnCartaCuatro.Name = "rBtnCartaCuatro";
            rBtnCartaCuatro.Size = new Size(62, 19);
            rBtnCartaCuatro.TabIndex = 17;
            rBtnCartaCuatro.TabStop = true;
            rBtnCartaCuatro.Text = "Carta 1";
            rBtnCartaCuatro.UseVisualStyleBackColor = true;
            // 
            // rBtnCartaCinco
            // 
            rBtnCartaCinco.AutoSize = true;
            rBtnCartaCinco.Location = new Point(23, 57);
            rBtnCartaCinco.Name = "rBtnCartaCinco";
            rBtnCartaCinco.Size = new Size(62, 19);
            rBtnCartaCinco.TabIndex = 18;
            rBtnCartaCinco.TabStop = true;
            rBtnCartaCinco.Text = "Carta 2";
            rBtnCartaCinco.UseVisualStyleBackColor = true;
            // 
            // rBtnCartaSeis
            // 
            rBtnCartaSeis.AutoSize = true;
            rBtnCartaSeis.Location = new Point(23, 82);
            rBtnCartaSeis.Name = "rBtnCartaSeis";
            rBtnCartaSeis.Size = new Size(62, 19);
            rBtnCartaSeis.TabIndex = 19;
            rBtnCartaSeis.TabStop = true;
            rBtnCartaSeis.Text = "Carta 3";
            rBtnCartaSeis.UseVisualStyleBackColor = true;
            // 
            // gbxJugadorUno
            // 
            gbxJugadorUno.Controls.Add(btnJugarUno);
            gbxJugadorUno.Controls.Add(rBtnCartaUno);
            gbxJugadorUno.Controls.Add(rBtnCartaDos);
            gbxJugadorUno.Controls.Add(rBtnCartaTres);
            gbxJugadorUno.Location = new Point(12, 10);
            gbxJugadorUno.Name = "gbxJugadorUno";
            gbxJugadorUno.Size = new Size(176, 156);
            gbxJugadorUno.TabIndex = 34;
            gbxJugadorUno.TabStop = false;
            gbxJugadorUno.Text = "Jugador 1";
            // 
            // btnJugarUno
            // 
            btnJugarUno.BackColor = SystemColors.ActiveBorder;
            btnJugarUno.Location = new Point(37, 126);
            btnJugarUno.Name = "btnJugarUno";
            btnJugarUno.Size = new Size(75, 23);
            btnJugarUno.TabIndex = 26;
            btnJugarUno.Text = "Jugar carta";
            btnJugarUno.UseVisualStyleBackColor = false;
            btnJugarUno.Click += btnJugarUno_Click;
            // 
            // rBtnCartaUno
            // 
            rBtnCartaUno.AutoSize = true;
            rBtnCartaUno.Location = new Point(23, 32);
            rBtnCartaUno.Name = "rBtnCartaUno";
            rBtnCartaUno.Size = new Size(62, 19);
            rBtnCartaUno.TabIndex = 14;
            rBtnCartaUno.TabStop = true;
            rBtnCartaUno.Text = "Carta 1";
            rBtnCartaUno.UseVisualStyleBackColor = true;
            // 
            // rBtnCartaDos
            // 
            rBtnCartaDos.AutoSize = true;
            rBtnCartaDos.Location = new Point(23, 57);
            rBtnCartaDos.Name = "rBtnCartaDos";
            rBtnCartaDos.Size = new Size(62, 19);
            rBtnCartaDos.TabIndex = 15;
            rBtnCartaDos.TabStop = true;
            rBtnCartaDos.Text = "Carta 2";
            rBtnCartaDos.UseVisualStyleBackColor = true;
            // 
            // rBtnCartaTres
            // 
            rBtnCartaTres.AutoSize = true;
            rBtnCartaTres.Location = new Point(23, 82);
            rBtnCartaTres.Name = "rBtnCartaTres";
            rBtnCartaTres.Size = new Size(62, 19);
            rBtnCartaTres.TabIndex = 16;
            rBtnCartaTres.TabStop = true;
            rBtnCartaTres.Text = "Carta 3";
            rBtnCartaTres.UseVisualStyleBackColor = true;
            // 
            // btnQuieroUno
            // 
            btnQuieroUno.BackColor = SystemColors.ActiveBorder;
            btnQuieroUno.Location = new Point(103, 285);
            btnQuieroUno.Name = "btnQuieroUno";
            btnQuieroUno.Size = new Size(85, 23);
            btnQuieroUno.TabIndex = 33;
            btnQuieroUno.Text = "Quiero!";
            btnQuieroUno.UseVisualStyleBackColor = false;
            // 
            // btnTrucoUno
            // 
            btnTrucoUno.BackColor = SystemColors.ActiveBorder;
            btnTrucoUno.Location = new Point(103, 256);
            btnTrucoUno.Name = "btnTrucoUno";
            btnTrucoUno.Size = new Size(85, 23);
            btnTrucoUno.TabIndex = 32;
            btnTrucoUno.Text = "Truco!";
            btnTrucoUno.UseVisualStyleBackColor = false;
            // 
            // btnFlorUno
            // 
            btnFlorUno.BackColor = SystemColors.ActiveBorder;
            btnFlorUno.Location = new Point(103, 227);
            btnFlorUno.Name = "btnFlorUno";
            btnFlorUno.Size = new Size(85, 23);
            btnFlorUno.TabIndex = 31;
            btnFlorUno.Text = "Flor!";
            btnFlorUno.UseVisualStyleBackColor = false;
            // 
            // btnFaltaEnvidoUno
            // 
            btnFaltaEnvidoUno.BackColor = SystemColors.ActiveBorder;
            btnFaltaEnvidoUno.Location = new Point(12, 285);
            btnFaltaEnvidoUno.Name = "btnFaltaEnvidoUno";
            btnFaltaEnvidoUno.Size = new Size(85, 23);
            btnFaltaEnvidoUno.TabIndex = 30;
            btnFaltaEnvidoUno.Text = "Falta Envido!";
            btnFaltaEnvidoUno.UseVisualStyleBackColor = false;
            // 
            // btnRealEnvidoUno
            // 
            btnRealEnvidoUno.BackColor = SystemColors.ActiveBorder;
            btnRealEnvidoUno.Location = new Point(12, 256);
            btnRealEnvidoUno.Name = "btnRealEnvidoUno";
            btnRealEnvidoUno.Size = new Size(85, 23);
            btnRealEnvidoUno.TabIndex = 29;
            btnRealEnvidoUno.Text = "Real Envido!";
            btnRealEnvidoUno.UseVisualStyleBackColor = false;
            // 
            // btnEnvidoUno
            // 
            btnEnvidoUno.BackColor = SystemColors.ActiveBorder;
            btnEnvidoUno.Location = new Point(12, 227);
            btnEnvidoUno.Name = "btnEnvidoUno";
            btnEnvidoUno.Size = new Size(85, 23);
            btnEnvidoUno.TabIndex = 28;
            btnEnvidoUno.Text = "Envido!";
            btnEnvidoUno.UseVisualStyleBackColor = false;
            // 
            // FrmMesaTruco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(589, 491);
            Controls.Add(lblFechaYHora);
            Controls.Add(lblCantoDos);
            Controls.Add(lblCantoUno);
            Controls.Add(btnCancelarJuego);
            Controls.Add(gbxPosiciones);
            Controls.Add(gbxMesa);
            Controls.Add(btnIrseDos);
            Controls.Add(btnQuieroDos);
            Controls.Add(btnTrucoDos);
            Controls.Add(btnFlorDos);
            Controls.Add(btnFaltaEnvidoDos);
            Controls.Add(btnRealEnvidoDos);
            Controls.Add(btnEnvidoDos);
            Controls.Add(btnIrseUno);
            Controls.Add(gbxJugadorDos);
            Controls.Add(gbxJugadorUno);
            Controls.Add(btnQuieroUno);
            Controls.Add(btnTrucoUno);
            Controls.Add(btnFlorUno);
            Controls.Add(btnFaltaEnvidoUno);
            Controls.Add(btnRealEnvidoUno);
            Controls.Add(btnEnvidoUno);
            Name = "FrmMesaTruco";
            Text = "FrmMesa";
            Load += FrmMesaTruco_Load;
            gbxPosiciones.ResumeLayout(false);
            gbxPosiciones.PerformLayout();
            gbxMesa.ResumeLayout(false);
            gbxMesa.PerformLayout();
            gbxJugadorDos.ResumeLayout(false);
            gbxJugadorDos.PerformLayout();
            gbxJugadorUno.ResumeLayout(false);
            gbxJugadorUno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaYHora;
        private Label lblCantoDos;
        private Label lblCantoUno;
        private Button btnCancelarJuego;
        private GroupBox gbxPosiciones;
        private Label lblPosicion2;
        private Label lblPosicion1;
        private GroupBox gbxMesa;
        private Label lblEnvidoDos;
        private Label lblEnvidoUno;
        private Label lblTanto;
        private Label lblValorDelTruco;
        private Label lblCarta3B;
        private Label lblValorTanto;
        private Label lblCarta3A;
        private Label lblMano3;
        private Label lblCarta2B;
        private Label lblCarta2A;
        private Label lblMano2;
        private Label lblCarta1B;
        private Label lblCarta1A;
        private Label lblMano1;
        private Button btnIrseDos;
        private Button btnQuieroDos;
        private Button btnTrucoDos;
        private Button btnFlorDos;
        private Button btnFaltaEnvidoDos;
        private Button btnRealEnvidoDos;
        private Button btnEnvidoDos;
        private Button btnIrseUno;
        private GroupBox gbxJugadorDos;
        private Button btnJugarDos;
        private RadioButton rBtnCartaCuatro;
        private RadioButton rBtnCartaCinco;
        private RadioButton rBtnCartaSeis;
        private GroupBox gbxJugadorUno;
        private Button btnJugarUno;
        private RadioButton rBtnCartaUno;
        private RadioButton rBtnCartaDos;
        private RadioButton rBtnCartaTres;
        private Button btnQuieroUno;
        private Button btnTrucoUno;
        private Button btnFlorUno;
        private Button btnFaltaEnvidoUno;
        private Button btnRealEnvidoUno;
        private Button btnEnvidoUno;
    }
}